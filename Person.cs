using System;
using System.Collections.Generic;
using System.Data;



namespace lucas
{
    //Creating a Class named "Person"
    public class Person
    {
        //Declair Varibails named Lastname,Firstname ,Birthdate and Mycar
        string Lastname;
        string Firstname;

        DateTime Birthdate;

        Car MyCar;

        //Hier it say´s that "Heute" is Today´s date

      DateTime heute = DateTime.Today;
 

   
  
      
       

        //Constructor
        public Person (string lastname, string firstname, DateTime birthdate, Car myCar)
        {
            //saying that Lastname = lastname is
            Lastname = lastname;
            //saying that Firstname = firstname is
            Firstname = firstname;
            //saying that Birthdate = birthdate is
            Birthdate = birthdate;
            //saying that MyCar = myCar is
            MyCar = myCar;
           
        
         
          
        }

        // Creatin a Funktion where you can display your Information 
        public void DisplayYourInformation ()
        {
            //hier it carculate the Birthate form the Totay´s date minis the birthyear
             int Alter = heute.Year - Birthdate.Year;
             //Output in the Console
            Console.WriteLine ($"{Firstname} {Lastname} {Birthdate.ToString("dd.mM.yyyy")} {Alter} {MyCar.GetCar()}");
        }
       
        
    }
    
}
