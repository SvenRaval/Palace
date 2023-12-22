namespace Park
{
    public class Vehicle
    {
        private double _size;
        public double Size 
        {
            get
            {
                Console.WriteLine($"Step 1.1 : [{GetType().Name}] size");
                return _size;
            }
        }
    }
}
