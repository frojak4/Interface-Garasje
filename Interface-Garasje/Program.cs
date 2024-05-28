namespace Interface_Garasje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<IVehicles>()
            {
                new Car("Ford", "Focus", 1999),
                new Boat("Yamaha", "Superboat", 2004)
            };

            vehicles[0].Year = 2026;

            foreach (var vehicle in vehicles )
            {
                Console.WriteLine($"{vehicle.brand} {vehicle.name} {vehicle.year}");
                vehicle.drive();
            }
        }
    }
}
