using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMagicalWorldOfBryne
{
    internal class Barnehage : SomePlace
    {
        private string BarnehageName { get; set; }
        public List<Person> barnehageList { get; set; }

        public Barnehage(string barnehagename) : base(barnehagename)
        {
            BarnehageName = barnehagename;
            barnehageList = new List<Person>();
        }

        public override void WhoIsHere()
        {
            Console.WriteLine($"Alle som er i {BarnehageName}:");
            foreach (var person in barnehageList)
            {
                Console.WriteLine("- " + person.Navn);
            }
        }

        public void PlayAndHaveFun()
        {
            foreach (var barn in barnehageList)
            {
                Console.Write($"{barn.Navn}, ");
            }
            Console.WriteLine("All decided to run around and screeeeaaammm\n\n\n");
            Console.WriteLine("Reeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
        }

        public void StayInBhg(Person barn)
        {
            barnehageList.Add(barn);
            Console.WriteLine($"{barn.Navn} went and joined the other kids...");
        }

        public void LeaveBhg(Person barn)
        {
            barnehageList.Remove(barn);
            Console.WriteLine($"{barn.Navn} went home from {this.BarnehageName}.");
        }

    }
}
