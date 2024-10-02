namespace Övning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfVehicles = new List<Vehicle>();
            listOfVehicles.Add(new Car());
            listOfVehicles.Add(new Boat());
            listOfVehicles.Add(new Bicycle());
            //listOfVehicles.Add(new Vehicle());


            foreach (var v in listOfVehicles) 
            {
                v.Go();
            }


        }
    }
}
