namespace VehiclesCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car aCar = new Car("Ford", "Fusion", 2016, 4);
            Car aCar1 = new Car("Chevy", "Equinox", 2010, 4);
            Car aCar2 = new Car("Nissan", "Altima", 2007, 2);

            Motorcycle aMotorcycle = new Motorcycle("Honda", "Interstate", 2015, true);
            Motorcycle aMotorcycle1 = new Motorcycle("Indian", "Challenger", 2010, false);

            Console.WriteLine(aCar.ToString());
            Console.WriteLine(aCar1.ToString());
            Console.WriteLine(aCar2.ToString());

            Console.WriteLine(aMotorcycle.ToString());
            Console.WriteLine(aMotorcycle1.ToString());
        }
    }
}
