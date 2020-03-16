using System;
using System.Collections.Generic;

namespace DatabaseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DataBeheer db = new DataBeheer(@"Data Source=DESKTOP-HT91N8R\SQLEXPRESS;Initial Catalog=TestDatabank;Integrated Security=True");

            //-----------------------Cursussen toevoegen----------------------//
            Cursus kaas = new Cursus(1, "kaasCursus");
            Cursus poes = new Cursus(2, "poesCursus");
            //db.VoegCursusToe(kaas);
            //db.VoegCursusToe(poes);
            
            //------------------------Klassen toevoegen-----------------------//
            Klas klas1 = new Klas(1, "klas1");
            Klas klas2 = new Klas(2, "klas2");
            //db.VoegKlasToe(klas1);
            //db.VoegKlasToe(klas2);

            Student st1 = new Student("st1", klas1);
            Student st2 = new Student("st2", klas2);
            Student st3 = new Student("st3", klas2);
            Student st4 = new Student("st4", klas2);

            //db.VoegStudentToe(st1);
            //db.VoegStudentToe(st2);
            //db.VoegStudentToe(st3);
            //db.VoegStudentToe(st4);


            //----------------------Cursus updaten-------------------------//
            //Cursus curs = new Cursus(1, "curs");

            //db.UpdateCursus(curs);



            //--------------Testen VoegStudentMetCursussenToe--------------------//
            //db.VoegStudentMetCursussenToe(st1);
            //db.VoegStudentMetCursussenToe(st2);
            //db.VoegStudentMetCursussenToe(st3);
            //db.VoegStudentMetCursussenToe(st4);


        }
    }
}

//Cursus cursus = db.GeefCursus(1);
//Console.WriteLine(cursus);

//IEnumerable<Cursus> cursussen = db.GeefCursussen();
//foreach(Cursus cursu in cursussen)
//{
//    Console.WriteLine(cursu);
//}
