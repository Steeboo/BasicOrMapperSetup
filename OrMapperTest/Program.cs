using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrMapperTest
{
    class Program
    {      
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var leraarToAdd = new Leraar { Naam = "Stefan", Leeftijd = 38 };

                context.Leraren.Add(leraarToAdd);

                leraarToAdd.Leeftijd = 14;

                context.SaveChanges();

                Console.WriteLine("Done!");

                Console.ReadKey();
            }

        }
    }
}
