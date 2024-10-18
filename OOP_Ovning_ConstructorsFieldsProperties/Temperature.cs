namespace OOP_Ovning_ConstructorsFieldsProperties
{
    internal class Temperature
    {
        private double _celsius;
        public double Celsius
        {
            get { return _celsius; }
            set { _celsius = value; }
        }
        public double Fahrenheit
        {
            get { return _celsius * 1.8 + 32; }
            set { _celsius = value; }
        }
        public double Kelvin
        {
            get { return _celsius + 273.15; }
            set { _celsius = value; }
        }
        public Temperature(double celsius)
        {
            Celsius = celsius;
        }

        public void ShowTemp()
        {
            Console.WriteLine($"Temperature is {Celsius}ºC, {Fahrenheit} Fahrenheit or {Kelvin} Kelvin.");
        }

        public void AddTemp(double value)
        {
            Celsius += value;
        }
    }
}
