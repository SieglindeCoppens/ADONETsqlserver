using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseTest
{
    public class Klas
    {
        public int Id { get; set; }
        public string KlasNaam { get; set; }
        public Klas(string naam)
        {
            KlasNaam = naam;
        }
        public Klas(int id, string naam)
        {
            Id = id;
            KlasNaam = naam;
        }
        public override string ToString()
        {
            return $"{Id} {KlasNaam}";
        }
    }
}
