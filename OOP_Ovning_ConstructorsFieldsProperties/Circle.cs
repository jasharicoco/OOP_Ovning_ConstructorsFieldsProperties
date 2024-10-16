using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ovning_ConstructorsFieldsProperties
{
    internal class Circle
    {
        private double _radius;

        public double Diameter
        {
            get { return _radius * 2; }
        }

        public double Area
        {
            get { return Math.PI * _radius * _radius; }
        }

        public Circle(double radius)
        {
            _radius = radius;
        }

        public void IncreaseByFactor(double factor)
        {
            _radius *= factor;
        }
    }
}
