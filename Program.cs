using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Spisok myCollection = new Spisok();
            myCollection.Sborka = new Sakas[3];

            myCollection.Sborka[0] = new Sakas()
            {
                Artist = "Artist1",
                Album = "Album1",
                Title = "Title1",
                Year = "2015"
            };
            myCollection.Sborka[1] = new Sakas()
            {
                Artist = "Artist2",
                Album = "Album2",
                Title = "Title2",
                Year = "2015"
            };
            myCollection.Sborka[2] = new Sakas()
            {
                Artist = "Artist3",
                Album = "Album3",
                Title = "Title3",
                Year = "2015"
            };


            string serialized = JsonConvert.SerializeObject(myCollection);

            Console.WriteLine(serialized);
            File.WriteAllText(@"C:\Users\z_m_1\source\repos\ConsoleApp8\ConsoleApp8\List.txt", serialized);
            Console.ReadKey();
        }
    }
}
