using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TheMagicalWorldOfBryne
{
    internal class Huset : SomePlace
    {
        string HouseName { get; set; }

        public List<Person> Beboere { get; set; }
        public Huset(string housename) : base(housename)
        {
            HouseName = housename;
            Beboere = new List<Person>();
        }

        public override void WhoIsHere()
        {
            Console.WriteLine($"Alle som bor i {HouseName}:");
            foreach (var person in Beboere)
            {
                Console.WriteLine("- " + person.Navn);
            }
        }

    }
}
