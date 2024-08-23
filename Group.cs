using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace lucas
{


    
         public class Group
    {
        //inisaliert a list named Personlist
         List<Person> PersonList;
        

        //Constructor
        public Group ()
        {
            //Creatin a New PersonList
           PersonList = new List<Person>();

        
        }
        //adding new person´s
        public void AddPerson (Person person)
        {
            //unsing the Funktion 
            PersonList.Add(person);
        }

        //ceartin a Funktion where you can display your name
        public void DisplayYourNames ()
        {
            //hier its starts a Foreach Loop thats display´s the information of the p = persons in Personlist
            foreach(Person p in PersonList)
            {
                //unsing the funktion DispalyYourInformation
                p.DisplayYourInformation();
            }
        }
    }
     
}