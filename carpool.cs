namespace lucas
{


    
         public class carpool
         {
            List<Car> Carpool;

            public carpool()
            {
                Carpool = new List<Car>();
            }
            public void addcar(Car car)
            {
                Carpool.Add(car);
            }
            public void Displaycars()
            {
                foreach(Car p in Carpool)
                {
                   p.Displaycar(); 
                }
            }
         }
}