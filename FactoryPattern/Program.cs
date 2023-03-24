namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires would you like to use to build " +
                "your toy?\nPlease enter \n2: for Bicycle\n3: for Tricycle" +
                "\n4: for Go Cart");
            string userVehicle = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(userVehicle);

            vehicle.Drive();
        }
    }
}
