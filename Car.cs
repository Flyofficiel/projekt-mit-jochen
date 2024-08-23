using System;
// Using the namespace lucas
namespace lucas
{
    //Creatin a class named Car
    public class Car
    {

        //Variable Car Brand
        string Marke;
        //Variable Car Typ
        string Typ;
        //Variable Car Buildjahr
        int Baujahr;
        //Variable Car ID
        public int Id;

        // Creatin a Funktion named Car and use the Varibails that stands above
        public Car(int id, string marke,string typ , int baujahr)
        {
            //saying that ID = id is
            Id = id;
            //saying that "Marke" = "marke" is
            Marke = marke;
            //saying that Typ = typ is
            Typ = typ;
            //saying that Baujahr = baujahr is
            Baujahr = baujahr;


        }
        // A Funktion  to Display the Car´s
        public void Displaycar () 
        {
            //Console Output
            Console.WriteLine($"{Marke} {Typ} {Baujahr} ");
        }

        // Creating a funktion that returns the id information
        public string GetCar () {
            return $"{Marke} {Typ} {Baujahr}";
        }
    }
}