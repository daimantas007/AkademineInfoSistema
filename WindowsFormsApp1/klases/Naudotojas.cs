using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public abstract class Naudotojas
{
    public int Id { get; set; }
    public string Vardas { get; set; }
    public string Pavarde { get; set; }
    public string Role { get; set; }

    public Naudotojas(int id, string vardas, string pavarde, string role)
    {
        Id = id;
        Vardas = vardas;
        Pavarde = pavarde;
        Role = role;
    }

    public abstract void Prisijungti();
}