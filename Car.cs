using System;

namespace lucas
{
    public class Car
    {
        string Marke;
        string Typ;
        int Baujahr;
        


        public Car(string marke,string typ , int baujahr)
        {
            Marke = marke;
            Typ = typ;
            Baujahr = baujahr;


        }
        public void Displaycar () 
        {
            Console.WriteLine($"{Marke} {Typ} {Baujahr} ");
        }
    }
}