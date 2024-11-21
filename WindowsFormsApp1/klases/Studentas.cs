using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Studentas : Naudotojas
{
    public List<Vertinimas> Pazymiai { get; set; }

    public Studentas(int id, string vardas, string pavarde, string role)
        : base(id, vardas, pavarde, role)
    {
    }

    public override void Prisijungti()
    {
        Console.WriteLine($"Studentas {Vardas} prisijungė.");
    }
}

