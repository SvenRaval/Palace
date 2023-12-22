namespace Park
{
    public class ParkingLot
    {
        public void Park(Vehicle vehicle)
        {
            Console.WriteLine($"Step : [{GetType().Name}] park");
        }
    }
}
