using System;
using System.Collections.Generic;
using System.Data;



namespace lucas
{
    public class Person
    {
        string Lastname;
        string Firstname;

        DateTime Birthdate;
      DateTime heute = DateTime.Today;
 

   
  
      
       

        //Constructor
        public Person (string lastname, string firstname, DateTime birthdate)
        {
            Lastname = lastname;
            Firstname = firstname;
            Birthdate = birthdate;
        
         
          
        }

        public void DisplayYourInformation ()
        {
             int Alter = heute.Year - Birthdate.Year;
            Console.WriteLine ($"{Firstname} {Lastname} {Birthdate.ToString("dd.mM.yyyy")} {Alter} ");
        }
       
        
    }
    
}
