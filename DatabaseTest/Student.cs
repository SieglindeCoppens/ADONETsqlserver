using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseTest
{
    public class Student
    {
        public List<Cursus> Cursussen { get; set; }
        public Klas Klas { get; set; }
        public string Naam { get; set; }
        public int StudentId { get; set; }
        public Student(string naam, Klas klas)
        {
            Klas = klas;
            Naam = naam;
        }
        public Student(int id, string naam, Klas klas)
        {
            StudentId = id;
            Klas = klas;
            Naam = naam;

        }

        public void ShowStudent()
        {
            Console.WriteLine($"{Naam}  {Klas}  {StudentId}");
            foreach(Cursus cursus in Cursussen)
            {
                Console.WriteLine(cursus);
            }
        }
        public void voegCursusToe(Cursus cursus)
        {
            Cursussen.Add(cursus);
        }
        
    }   
}
