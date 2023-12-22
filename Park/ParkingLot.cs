namespace Park
{
    public class ParkingLot
    {
        public List<Vehicle> _parkedVehicles = new List<Vehicle> { };
        public void Park(Vehicle vehicleToPark)
        {
            Console.WriteLine($"Step 1 : [{GetType().Name}] park");
            double size = vehicleToPark.Size;

            if (!IsVehicleAlreadyParked(vehicleToPark))
            {
                Console.WriteLine($"Step 1.2 : [{GetType().Name}] already parked ?");

            }
        }

        public bool IsVehicleAlreadyParked(Vehicle vehicleToPark)
        {
            foreach (Vehicle currentVehicle in _parkedVehicles)
            {
                return true;
            }
            return false;
        }

        private Valet chooseValet(Valet valet)
        {
            return new Valet();
        }
    }
}
