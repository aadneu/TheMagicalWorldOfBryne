using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TheMagicalWorldOfBryne
{
    internal class Butikken : SomePlace
    {
        string ShopName { get; set; }
        public List<Vare> Dagligvarer { get; set; }
        public List<Person> ButikkAnsatte { get; set; }

        public Butikken(string shopname) : base (shopname)
        {
            ShopName = shopname;
            ButikkAnsatte = new List<Person>();
            Dagligvarer = new List<Vare>()
            {
                new Vare("Tannkrem"),
                new Vare("Coca-Cola"),
                new Vare("Brød"),
                new Vare("Fisk"),
                new Vare("Toalettpapir"),
                new Vare("Yoghurt"),
            };

        }
        public override void WhoIsHere()
        {
            Console.WriteLine($"Alle som jobber på {ShopName}:");
            foreach (var person in ButikkAnsatte)
            {
                Console.WriteLine("- " + person.Navn);
            }
        }

        public void DisplayVare(Person person)
        {
            Console.WriteLine($"Velkommen til Kiwi Bryne, {person.Navn}!\n");
            Console.WriteLine("Vi har følgende varer til salgs: \n");
            for (int i = 0; i < Dagligvarer.Count; i++)
            {
                Console.WriteLine(i + " - " + Dagligvarer[i].VareType);
            }
        }

        public void CheckIfEmpty(Person person)
        {
            Console.WriteLine("\n");

            if (Dagligvarer == null || Dagligvarer.Count == 0)
            {
                Console.WriteLine("Beklager, butikken er tom for varer!")
                    ; return;
            }
            HvaVilDuHa(person);
        }

        void RemoveFromList(Vare vare)
        {
            Dagligvarer.Remove(vare);
        }

        void HvaVilDuHa(Person person)
        {
            Console.Write("Hva vil du ha i dag? ");
            var input = Convert.ToInt32(Console.ReadLine());
            var SelectedVare = Dagligvarer[input];
            
            Console.WriteLine($"{person.Navn} kjøpte {Dagligvarer[input].VareType}");
            
            person.BuyStuff(person, SelectedVare);
            
            RemoveFromList(SelectedVare);
            
          
        }

    }
}
