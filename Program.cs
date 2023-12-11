// See https://aka.ms/new-console-template for more information

using TheMagicalWorldOfBryne;


// huset og beboere
var hus = new Huset("HomeSweetHome");
hus.Beboere.AddRange(new List<Person>
{
    new Person("ådnefar", "35"),
    new Person("miniÅdne", "1"),
    new Person("ådnesbedrehalvdel", "31")
});

//ølutsalg og ansatte
var øl = new Ølutsalget("Vaaland");
øl.ØlAnsatte.AddRange(new List<Person>
{
    new Person("Jens"),
    new Person("Harry")
});

// barn i barnehagen
var bhg = new Barnehage("Spira");
bhg.barnehageList.AddRange( new List<Person>
{
    new Person("Per", "1"),
    new Person("Pål","1"),
    new Person("Espen","1")
});

//butikk og ansatte
var butikk = new Butikken("Kiwi");
butikk.ButikkAnsatte.Add(new Person("Sabeltann", "54"));
butikk.ButikkAnsatte.Add(new Person("Sheere Khan", "22"));

// byen og eg liste med de forskjellige plassene. som alle dele "base" someplace
var Bryne = new Bryne();
Bryne.PlaceList.AddRange(new List<SomePlace>()
{
    bhg, butikk, øl, hus
});

Person MainCharacter = hus.Beboere[0];

Bryne.ShowPlaces();

//øl.DisplayBeer(MainCharacter);
//øl.HvaDrikkerDuIdag(MainCharacter);

//MainCharacter.Handlepose();
//øl.DisplayBeer(MainCharacter);

//butikk.DisplayVare(MainCharacter);
//butikk.CheckIfEmpty(MainCharacter);

//MainCharacter.Handlepose();


//øl.DisplayBeer();
//bhg.PlayAndHaveFun();

//butikk.DisplayVare();
//Bryne.ShowPlaces();

//Bryne.ShowAllCitizens();


