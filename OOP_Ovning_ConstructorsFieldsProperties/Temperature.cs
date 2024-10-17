namespace OOP_Ovning_ConstructorsFieldsProperties
{
    internal class Temperature
    {
        private double _celsius;
        public double Celsius
        {
            get { return _celsius; }
            set
            {
                _celsius = value;
                _fahrenheit = (_celsius * 9 / 5) + 32;
                _kelvin = _celsius + 273.15;
            }
        }

        private double _fahrenheit;
        public double Fahrenheit
        {
            get { return _fahrenheit; }
            set
            {
                _fahrenheit = value;
                _celsius = (value - 32) * 5 / 9;
                _kelvin = _celsius + 273.15;
            }
        }

        private double _kelvin;
        public double Kelvin
        {
            get { return _kelvin; }
            set
            {
                _kelvin = value;
                _celsius = value - 273.15;
                _fahrenheit = (_celsius * 9 / 5) + 32;
            }
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
