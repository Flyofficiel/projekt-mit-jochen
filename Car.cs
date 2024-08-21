using System;

namespace lucas
{
    public class Car
    {
        string Marke;
        string Typ;
        int Baujahr;
        
        public int Id;


        public Car(int id, string marke,string typ , int baujahr)
        {
            Id = id;
            Marke = marke;
            Typ = typ;
            Baujahr = baujahr;


        }
        public void Displaycar () 
        {
            Console.WriteLine($"{Marke} {Typ} {Baujahr} ");
        }

        public string GetCar () {
            return $"{Marke} {Typ} {Baujahr}";
        }
    }
}