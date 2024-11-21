using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dalykas
{
    public int Id { get; set; }
    public string Pavadinimas { get; set; }
    public int DestytojasId { get; set; }
}

public class Vertinimas
{
    public int Id { get; set; }
    public int StudentasId { get; set; }
    public int DalykasId { get; set; }
    public int Pazymys { get; set; }
}