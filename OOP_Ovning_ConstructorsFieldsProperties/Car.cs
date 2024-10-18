namespace OOP_Ovning_ConstructorsFieldsProperties
{
    internal class Car
    {
        private static int _instanceCount = 0;
        private static int _totalAge = 0;
        
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

            int currentYear = DateTime.Now.Year;
            _totalAge += (currentYear - _year);
        }

        public void Present()
        {
            Console.WriteLine($"This car is a {_brand} {_model} from {_year}");
        }

        public static int AverageAge()
        {
            if (_instanceCount == 0) return 0; // In case of no cars

            return _totalAge / _instanceCount;
        }
    }
}
