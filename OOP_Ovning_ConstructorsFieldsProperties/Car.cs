namespace OOP_Ovning_ConstructorsFieldsProperties
{
    internal class Car
    {
        private static int _instanceCount = 0;
        private static List<Car> _instances = new List<Car>();
        
        private string _brand;
        private string _model;
        private int _year;

        public static int InstanceCount
        {
            get { return _instanceCount; }
        }

        public Car(string brand, string model, int year)
        {
            _brand = brand;
            _model = model;
            _year = year;
            _instanceCount++;
            _instances.Add(this);
        }

        public void Present()
        {
            Console.WriteLine($"This car is a {_brand} {_model} from {_year}");
        }

        public static double AverageYear()
        {
            if (_instances.Count == 0) return 0; // In case of no cars

            double total = 0;
            foreach (var car in _instances)
            {
                total += car._year; // Add each cars year in the total sum
            }

            return (total / _instances.Count); // Calculate average
        }
    }
}
