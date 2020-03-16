using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseTest
{
    public class Cursus
    {
        public string Cursusnaam { get; set; }
        public int Id { get; set; }

        public Cursus(string naam)
        {
            Cursusnaam = naam;
        }
        public Cursus(int id, string naam)
        {
            Id = id;
            Cursusnaam = naam;
        }
        public override string ToString()
        {
            return $"{Id} {Cursusnaam}";
        }
    }
}
