using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMagicalWorldOfBryne
{
    internal class Bryne
    {
        public List<SomePlace> PlaceList { get; set; }

        public Bryne()
        {
          PlaceList = new List<SomePlace>();
        }

        public void ShowPlaces()
        {
            foreach (var place in PlaceList)
            {
                Console.WriteLine(place.PlaceName);
            }
        }
        
        public void ShowAllCitizens()
        {
            foreach (var place in PlaceList)
            {
                place.WhoIsHere();
            }
        }
       

    }
}
