using System;
using System.Collections.Generic;

namespace lucas
{
    public class Person
    {
        string Lastname;
        string Firstname;

        //Constructor
        public Person (string lastname, string firstname)
        {
            Lastname = lastname;
            Firstname = firstname;
        }

        public void DisplayYourName ()
        {
            Console.WriteLine ($"Ich heisse {Firstname} {Lastname}");
        }
    }
    public class group
    {
       string Lastname;
       string Firstname;

            //Constructor
        public tester (string lastname, string firstname)
        {
            Lastname = lastname;
            Firstname = firstname;
        }
            static void DisplayNames(string[] args)
            {
          
                List<string> persons = new List<string>();
            
                persons.Add(lastname , firstname);

                foreach (string personen in persons)
                {
                    Console.WriteLine(personen);
                }



            }
    }
}

