using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Destytojas : Naudotojas
{
    public List<Dalykas> Dalykai { get; set; }

    public Destytojas(int id, string vardas, string pavarde, string role)
        : base(id, vardas, pavarde, role)
    {
    }

    public override void Prisijungti()
    {
        Console.WriteLine($"Dėstytojas {Vardas} prisijungė.");
    }
}