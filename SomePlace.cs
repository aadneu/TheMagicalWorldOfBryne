using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMagicalWorldOfBryne
{
    internal abstract class SomePlace
    {
        public string PlaceName { get; set; }

        public SomePlace(string placename)
        {
            PlaceName = placename;
        }

        // måtte legge til abstract på class og på metode, for at showallcitizens metode skulle fungere, og de har fått
        // override i metoden på hver enkelt klasse.
        public abstract void WhoIsHere();
    }
}
