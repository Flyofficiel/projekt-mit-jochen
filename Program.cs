using lucas;

class Program1
{
    static void Main (string[] args)
    {
        // Creating a List of Persons
        Group personList = new Group();
        personList.AddPerson(new Person (lastname:"Huber",firstname:"Lucas",day:07 , month:03 , year:2007 ));
         personList.AddPerson(new Person (lastname:"Wunder",firstname:"Jochen",day:07 , month:03 , year:2007 ));
         personList.AddPerson(new Person (lastname:"Wolf",firstname:"Patrick",day:07 , month:03 , year:2007 ));
         personList.DisplayYourNames();
    }
}