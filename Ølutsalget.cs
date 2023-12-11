using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TheMagicalWorldOfBryne
{
    internal class Ølutsalget : SomePlace

    {
        public string ØlButikkNavn { get; set; }
        public List<Vare> øList { get; set; }
        public List<Person> ØlAnsatte { get; set; }

        public Ølutsalget(string ølbutikknavn) : base (ølbutikknavn)
        {
            ØlButikkNavn = ølbutikknavn;
            ØlAnsatte = new List<Person>();
            øList = new List<Vare>()
            {
                new Vare("Berentsen"),
                new Vare("Isbjørn"),
                new Vare("Hansa"),
                new Vare("Tuborg"),
            };
        }

        void RemoveFromList(Vare vare)
        {
            øList.Remove(vare);
        }

        public override void WhoIsHere()
        {
            Console.WriteLine($"Alle som jobber på {ØlButikkNavn}:");
            foreach (var person in ØlAnsatte)
            {
                Console.WriteLine("- " + person.Navn);
            }
        }

        public void DisplayBeer(Person person)
        {
            Console.WriteLine("Vi har følgende øl til salgs: \n");
            for (int i = 0; i < øList.Count; i++)
            {
                Console.WriteLine(i + " - " + øList[i].VareType);
            }
        }

        public void HvaDrikkerDuIdag(Person person)
        {
            Console.WriteLine("\nHva frister mest? ");
            var input = Convert.ToInt32(Console.ReadLine());
            var selectedVare = øList[input];
            Console.WriteLine($"\n{person.Navn} fylte opp posen med {selectedVare.VareType} ");
            person.BuyStuff(person, selectedVare);
            RemoveFromList(selectedVare);
        }
    }
}
