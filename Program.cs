using System.Globalization;
using System.Linq.Expressions;
using lucas;
using Microsoft.VisualBasic;

class Program1
{
    static void Main (string[] args)
    {
        // Creating a List of Persons
        Group personList = new Group();
        CultureInfo cultureInfo = new CultureInfo("de-DE");
        personList.AddPerson(new Person (lastname:"Huber",firstname:"Lucas", birthdate: DateTime.Parse("07.03.2008", cultureInfo)));
         personList.AddPerson(new Person (lastname:"Wunder",firstname:"Jochen", birthdate: DateTime.Parse("04.11.1967", cultureInfo) ));
         personList.AddPerson(new Person (lastname:"Wolf",firstname:"Patrick", birthdate: DateTime.Parse("30.11.1985", cultureInfo)));
         personList.AddPerson(new Person(lastname:"Tauschke",firstname:"Jessica", birthdate: DateTime.Parse("07.03.2008", cultureInfo)));
         personList.AddPerson(new Person(lastname:"Gawel",firstname:"Damian", birthdate: DateTime.Parse("07.03.2008", cultureInfo)));
         personList.AddPerson(new Person (lastname:"Baselt",firstname:"Yenelle", birthdate: DateTime.Parse("07.03.2008", cultureInfo)));
         personList.AddPerson(new Person(lastname:"Right",firstname:"Massi", birthdate: DateTime.Parse("07.03.2008", cultureInfo)));
         personList.AddPerson(new Person(lastname:"Gawel",firstname:"Adam", birthdate: DateTime.Parse("07.03.2008", cultureInfo)));
         personList.AddPerson(new Person(lastname: "huber", firstname:"julian" , birthdate: DateTime.Parse("01.01.2000" , cultureInfo)));

         personList.DisplayYourNames();
    }
}