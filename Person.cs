using System;
using System.Collections.Generic;



namespace lucas
{
    public class Person
    {
        string Lastname;
        string Firstname;
        int Year;
        int Month;
        int Day;
      

       

        //Constructor
        public Person (string lastname, string firstname , int day , int month , int year )
        {
            Lastname = lastname;
            Firstname = firstname;
            Year = year;
            Month = month;
            Day = day;
            

        }
        public void birthday (int year, int month, int day) {}

        public void DisplayYourInformation ()
        {
            Console.WriteLine ($"{Firstname} {Lastname} {Day} {Month} {Year}");
        }
    }
    
}
