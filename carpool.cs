namespace lucas
{


        // Creatin a Carpool
         public class carpool
         {
            //Inisaliert a lsit named Carpool
            List<Car> Carpool;

            public carpool()
            {
                //Creatin a new Carpool
                Carpool = new List<Car>();
            }
            //Funktion to add a new car
            public void addcar(Car car)
            {
                Carpool.Add(car);
            }

            //Creatin a Funktion to Display the car´s
            public void Displaycars()
            {
                //it start a Foreach Loop
                foreach(Car p in Carpool)
                {
                    // hier it use the Funktion displaycar
                   p.Displaycar(); 
                }
            }

            //a Funktion to get the ID of a Car
            public Car GetCarById (int id)
            {
                //Returnung the Car by ID
                return Carpool.FirstOrDefault(i => i.Id == id); 
            }
         }
}