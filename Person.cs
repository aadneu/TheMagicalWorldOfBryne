
namespace TheMagicalWorldOfBryne
{
    internal class Person
    {
        public string Navn { get; set; }
        private string Alder { get; set; }
       // public List<Person> familie { get; set; }
       public List<Vare> Vareliste;


       public Person(string navn)
       {
           Navn = navn;
           Vareliste = new List<Vare>();
       }
        public Person(string navn, string alder)
        {
            Navn = navn;
            Alder = alder;
            Vareliste = new List<Vare>();
        }

        

        public void Handlepose()
        {
            Console.WriteLine("\nHandleposen inneholder: \n");
            if (Vareliste.Count > 0)
            {
                foreach (var vare in Vareliste)
                {
                    Console.WriteLine("- " + vare.VareType);   
                }
            }
            else 
            {
                Console.WriteLine("Ingenting");
            }
        }

        void LeaveHouseAndGoTo(Person person)
        {
            Console.WriteLine("Where do you want to go? ");
            Bryne.ShowPlaces();
        }

        public void BuyStuff(Person person, Vare vare)
        {
            person.Vareliste.Add(vare);
        }


    }
}
