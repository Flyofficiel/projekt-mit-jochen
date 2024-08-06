using System.Linq.Expressions;
using lucas;
using Microsoft.VisualBasic;

class Program1
{
    static void Main (string[] args)
    {
        // Creating a List of Persons
        Group personList = new Group();
        personList.AddPerson(new Person (lastname:"Huber",firstname:"Lucas",day:07 , month:03 , year:2007));
         personList.AddPerson(new Person (lastname:"Wunder",firstname:"Jochen",day:07 , month:03 , year:2007 ));
         personList.AddPerson(new Person (lastname:"Wolf",firstname:"Patrick",day:07 , month:03 , year:2007 ));
         personList.AddPerson(new Person(lastname:"Tauschke",firstname:"Jessica",day:04,month:06,year:1989));
         personList.AddPerson(new Person(lastname:"Gawel",firstname:"Damian",day:26,month:06,year:1988));
         personList.AddPerson(new Person (lastname:"Baselt",firstname:"Yenelle",day:11,month:02,year:2011));
         personList.AddPerson(new Person(lastname:"Right",firstname:"Massi",day:20,month:04,year:1988));
         personList.AddPerson(new Person(lastname:"Gawel",firstname:"Adam", day:25,month: 5,year:1960));

         personList.DisplayYourNames();
    }
}