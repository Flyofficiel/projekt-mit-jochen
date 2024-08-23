using System.Globalization;
using System.Linq.Expressions;
using lucas;
using Microsoft.VisualBasic;

//Creating a Class named Program1
class Program1
{
    //thats the main funktion in this Class and projekt
    static void Main (string[] args)
    {
        // adding a Blank
        Console.WriteLine(" ");
        //Creating Car Pool
        carpool Carpool = new carpool();
         Carpool.addcar(new Car( id:1, marke:"BMW" , typ:"M4" , baujahr:2024));
         Carpool.addcar(new Car(id:2, marke:"BMW" , typ: "X2" , baujahr:2020));
         Carpool.addcar(new Car(id:3, marke:"Mercedes" , typ:"G Klasse" , baujahr:2020));
         Carpool.addcar(new Car(id:4, marke:"Nissan" , typ:"GTR" , baujahr:2020));
         // Displaying the Carpool
         Carpool.Displaycars();
         // adding a blank
         Console.WriteLine(" ");
        // Creating a List of Persons
        Group personList = new Group();
        CultureInfo cultureInfo = new CultureInfo("de-DE");
         //Adding a Bunch of Person´s
        personList.AddPerson(new Person (lastname:"Huber",firstname:"Lucas", birthdate: DateTime.Parse("07.03.2008", cultureInfo), myCar: Carpool.GetCarById(1)));
         personList.AddPerson(new Person (lastname:"Wunder",firstname:"Jochen", birthdate: DateTime.Parse("04.11.1967", cultureInfo), myCar: Carpool.GetCarById(2) ));
         personList.AddPerson(new Person (lastname:"Wolf",firstname:"Patrick", birthdate: DateTime.Parse("30.11.1985", cultureInfo), myCar: Carpool.GetCarById(1)));
         personList.AddPerson(new Person(lastname:"Tauschke",firstname:"Jessica", birthdate: DateTime.Parse("04.05.2008", cultureInfo), myCar: Carpool.GetCarById(3)));
         personList.AddPerson(new Person(lastname:"Gawel",firstname:"Damian", birthdate: DateTime.Parse("26.06.2008", cultureInfo), myCar: Carpool.GetCarById(4)));
         personList.AddPerson(new Person (lastname:"Baselt",firstname:"Yenelle", birthdate: DateTime.Parse("11.02.2008", cultureInfo), myCar: Carpool.GetCarById(3)));
         personList.AddPerson(new Person(lastname:"Right",firstname:"Massi", birthdate: DateTime.Parse("07.03.2008", cultureInfo), myCar: Carpool.GetCarById(1)));
         personList.AddPerson(new Person(lastname:"Gawel",firstname:"Adam", birthdate: DateTime.Parse("07.03.2008", cultureInfo), myCar: Carpool.GetCarById(2)));
         personList.AddPerson(new Person(lastname: "huber", firstname:"julian" , birthdate: DateTime.Parse("01.01.2000" , cultureInfo), myCar: Carpool.GetCarById(4)));
          // Display´s all the information in Personlist
         personList.DisplayYourNames();
        
         //adding a Blank
        Console.WriteLine(" ");
         
    }
}