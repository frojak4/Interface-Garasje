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

            foreach (var vehicle in vehicles )
            {
                vehicle.drive();
            }
        }
    }
}
