using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

public class DatabaseService
{
    private string connectionString = "Server=localhost;Database=akademinesistema;Uid=root;Pwd=;";

    public List<Dalykas> GautiDalykus()
    {
        var dalykai = new List<Dalykas>();
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT ID, Pavadinimas FROM Dalykai";
            using (var command = new MySqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    dalykai.Add(new Dalykas
                    {
                        Id = reader.GetInt32("ID"),
                        Pavadinimas = reader.GetString("Pavadinimas")
                    });
                }
            }
        }
        return dalykai;
    }




    public Naudotojas Prisijungti(string prisijungimoVardas, string slaptazodis)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Naudotojai WHERE LOWER(Vardas) = @vardas AND LOWER(Pavarde) = @slaptazodis";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@vardas", prisijungimoVardas.ToLower());
                command.Parameters.AddWithValue("@slaptazodis", slaptazodis.ToLower());

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = reader.GetInt32("ID");
                        string vardas = reader.GetString("Vardas");
                        string pavarde = reader.GetString("Pavarde");
                        string role = reader.GetString("Role");

                        if (role == "Administratorius")
                            return new Administratorius(id, vardas, pavarde, role);
                        else if (role == "Destytojas")
                            return new Destytojas(id, vardas, pavarde, role);
                        else if (role == "Studentas")
                            return new Studentas(id, vardas, pavarde, role);
                    }
                }
            }
        }

        return null; // Jei naudotojas nerastas
    }



    public DataTable GautiVisusNaudotojus()
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT ID, Vardas, Pavarde, Role FROM Naudotojai";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var adapter = new MySqlDataAdapter(command))
                {
                    DataTable naudotojai = new DataTable();
                    adapter.Fill(naudotojai);
                    return naudotojai;
                }
            }
        }
    }

    public void PridetiNaudotoja(string vardas, string pavarde, string role)
    {
        string prisijungimoVardas = vardas.ToLower();
        string slaptazodis = pavarde.ToLower();

        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Naudotojai (Vardas, Pavarde, Role, PrisijungimoVardas, Slaptazodis) " +
                           "VALUES (@vardas, @pavarde, @role, @prisijungimoVardas, @slaptazodis)";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@vardas", vardas);
                command.Parameters.AddWithValue("@pavarde", pavarde);
                command.Parameters.AddWithValue("@role", role);
                command.Parameters.AddWithValue("@prisijungimoVardas", prisijungimoVardas);
                command.Parameters.AddWithValue("@slaptazodis", slaptazodis);
                command.ExecuteNonQuery();
            }
        }
    }

    public void RedaguotiNaudotoja(int id, string vardas, string pavarde, string role)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "UPDATE Naudotojai SET Vardas = @vardas, Pavarde = @pavarde, Role = @role WHERE ID = @id";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@vardas", vardas);
                command.Parameters.AddWithValue("@pavarde", pavarde);
                command.Parameters.AddWithValue("@role", role);
                command.ExecuteNonQuery();
            }
        }
    }

    public void IstrintiNaudotoja(int id)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "DELETE FROM Naudotojai WHERE ID = @id";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }

    public DataTable GautiVisasGrupe()
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM StudentuGrupes";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var adapter = new MySqlDataAdapter(command))
                {
                    DataTable grupes = new DataTable();
                    adapter.Fill(grupes);
                    return grupes;
                }
            }
        }
    }

    public void KurtiGrupe(string grupesPavadinimas)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO StudentuGrupes (GrupesPavadinimas) VALUES (@pavadinimas)";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@pavadinimas", grupesPavadinimas);
                command.ExecuteNonQuery();
            }
        }
    }

    public void SalintiGrupe(int grupesId)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "DELETE FROM StudentuGrupes WHERE ID = @id";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", grupesId);
                command.ExecuteNonQuery();
            }
        }
    }

    public DataTable GautiStudentusGrupėje(int grupesId)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = @"SELECT Naudotojai.ID, Naudotojai.Vardas, Naudotojai.Pavarde 
                         FROM Naudotojai 
                         JOIN StudentaiGrupes ON Naudotojai.ID = StudentaiGrupes.StudentasID 
                         WHERE StudentaiGrupes.GrupesID = @grupesId";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@grupesId", grupesId);
                using (var adapter = new MySqlDataAdapter(command))
                {
                    DataTable studentai = new DataTable();
                    adapter.Fill(studentai);
                    return studentai;
                }
            }
        }
    }


    public DataTable GautiStudentusNeGrupėje()
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = @"SELECT ID, Vardas, Pavarde 
                         FROM Naudotojai 
                         WHERE Role = 'Studentas' 
                         AND ID NOT IN (SELECT StudentasID FROM StudentaiGrupes)";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var adapter = new MySqlDataAdapter(command))
                {
                    DataTable studentai = new DataTable();
                    adapter.Fill(studentai);
                    return studentai;
                }
            }
        }
    }


    public void PridetiStudentaGrupei(int studentasId, int grupesId)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO StudentaiGrupes (StudentasID, GrupesID) VALUES (@studentasId, @grupesId)";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@studentasId", studentasId);
                command.Parameters.AddWithValue("@grupesId", grupesId);
                command.ExecuteNonQuery();
            }
        }
    }

    public void PasalintiStudentaIsGrupes(int studentasId, int grupesId)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "DELETE FROM StudentaiGrupes WHERE StudentasID = @studentasId AND GrupesID = @grupesId";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@studentasId", studentasId);
                command.Parameters.AddWithValue("@grupesId", grupesId);
                command.ExecuteNonQuery();
            }
        }
    }

    public DataTable GautiVisusDalykus()
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT Dalykai.ID, Dalykai.Pavadinimas, Naudotojai.Vardas AS Destytojas " +
                           "FROM Dalykai LEFT JOIN Naudotojai ON Dalykai.DestytojasID = Naudotojai.ID";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var adapter = new MySqlDataAdapter(command))
                {
                    DataTable dalykai = new DataTable();
                    adapter.Fill(dalykai);
                    return dalykai;
                }
            }
        }
    }

    public void KurtiDalyka(string pavadinimas)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Dalykai (Pavadinimas) VALUES (@pavadinimas)";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@pavadinimas", pavadinimas);
                command.ExecuteNonQuery();
            }
        }
    }

    public void PriskirtiDestytojaDalykui(int dalykoId, int destytojasId)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "UPDATE Dalykai SET DestytojasID = @destytojasId WHERE ID = @dalykoId";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@dalykoId", dalykoId);
                command.Parameters.AddWithValue("@destytojasId", destytojasId);
                command.ExecuteNonQuery();
            }
        }
    }


    public void PriskirtiGrupeDalykui(int dalykoId, int grupesId)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO DalykaiGrupes (DalykasID, GrupesID) VALUES (@dalykoId, @grupesId)";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@dalykoId", dalykoId);
                command.Parameters.AddWithValue("@grupesId", grupesId);
                command.ExecuteNonQuery();
            }
        }
    }

    public DataTable GautiDestytojus()
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT ID, Vardas, Pavarde FROM Naudotojai WHERE Role = 'Destytojas'";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var adapter = new MySqlDataAdapter(command))
                {
                    DataTable destytojai = new DataTable();
                    adapter.Fill(destytojai);
                    return destytojai;
                }
            }
        }
    }


    public DataTable GautiDalykusDestytojui(int destytojasId)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = @"SELECT ID, Pavadinimas 
                         FROM Dalykai 
                         WHERE DestytojasID = @destytojasId";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@destytojasId", destytojasId);
                using (var adapter = new MySqlDataAdapter(command))
                {
                    DataTable dalykai = new DataTable();
                    adapter.Fill(dalykai);
                    return dalykai;
                }
            }
        }
    }


    public DataTable GautiGrupesDalykui(int dalykoId)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = @"SELECT StudentuGrupes.ID, StudentuGrupes.GrupesPavadinimas
                         FROM StudentuGrupes
                         JOIN DalykaiGrupes ON StudentuGrupes.ID = DalykaiGrupes.GrupesID
                         WHERE DalykaiGrupes.DalykasID = @dalykoId";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@dalykoId", dalykoId);
                using (var adapter = new MySqlDataAdapter(command))
                {
                    DataTable grupes = new DataTable();
                    adapter.Fill(grupes);
                    return grupes;
                }
            }
        }
    }




    public void PridetiIvertinima(int studentasId, int dalykoId, int pazymys)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = @"INSERT INTO Vertinimai (StudentasID, DalykasID, Pazymys)
                         VALUES (@studentasId, @dalykoId, @pazymys)
                         ON DUPLICATE KEY UPDATE Pazymys = @pazymys";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@studentasId", studentasId);
                command.Parameters.AddWithValue("@dalykoId", dalykoId);
                command.Parameters.AddWithValue("@pazymys", pazymys);
                command.ExecuteNonQuery();
            }
        }
    }


    public DataTable GautiStudentusGrupėjeSuPazymiais(int grupesId, int dalykoId)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = @"SELECT Naudotojai.ID AS StudentasID, Naudotojai.Vardas, Naudotojai.Pavarde, 
                                IFNULL(Vertinimai.Pazymys, NULL) AS Pazymys
                         FROM Naudotojai
                         JOIN StudentaiGrupes ON Naudotojai.ID = StudentaiGrupes.StudentasID
                         LEFT JOIN Vertinimai ON Naudotojai.ID = Vertinimai.StudentasID AND Vertinimai.DalykasID = @dalykoId
                         WHERE StudentaiGrupes.GrupesID = @grupesId";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@grupesId", grupesId);
                command.Parameters.AddWithValue("@dalykoId", dalykoId);
                using (var adapter = new MySqlDataAdapter(command))
                {
                    DataTable studentai = new DataTable();
                    adapter.Fill(studentai);
                    return studentai;
                }
            }
        }
    }

    public void PridetiArPakeistiPazymi(int studentasId, int dalykoId, int pazymys)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = @"INSERT INTO Vertinimai (StudentasID, DalykasID, Pazymys) 
                         VALUES (@studentasId, @dalykoId, @pazymys)
                         ON DUPLICATE KEY UPDATE Pazymys = @pazymys"; // Atnaujina, jei įrašas egzistuoja
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@studentasId", studentasId);
                command.Parameters.AddWithValue("@dalykoId", dalykoId);
                command.Parameters.AddWithValue("@pazymys", pazymys);
                command.ExecuteNonQuery();
            }
        }
    }


    public DataTable GautiStudentoPazymius(int studentasId)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = @"SELECT Dalykai.Pavadinimas AS Dalykas, 
                                IFNULL(Vertinimai.Pazymys, 'N/A') AS Pazymys
                         FROM Vertinimai
                         JOIN Dalykai ON Vertinimai.DalykasID = Dalykai.ID
                         WHERE Vertinimai.StudentasID = @studentasId;";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@studentasId", studentasId);
                using (var adapter = new MySqlDataAdapter(command))
                {
                    DataTable pazymiai = new DataTable();
                    adapter.Fill(pazymiai);
                    return pazymiai;
                }
            }
        }
    }



}

