using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace lucas
{


    
         public class Group
    {
         List<Person> PersonList;
        

        //Constructor
        public Group ()
        {
           PersonList = new List<Person>();

        
        }
        public void AddPerson (Person person)
        {
            PersonList.Add(person);
        }

        public void DisplayYourNames ()
        {
            foreach(Person p in PersonList)
            {
                p.DisplayYourInformation();
            }
        }
    }
     
}