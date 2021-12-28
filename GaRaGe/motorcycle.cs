using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Motorcycle : Vehicle
    {
        private string _vehicle;
        private double _cylinderVolume;



        public Motorcycle(string motorcycle, double cylindervolume, string licnr, string color, int numberofwheels, double weight)
            : base(motorcycle, licnr, color, numberofwheels, weight)
        {
            _vehicle = motorcycle;
            _cylinderVolume = cylindervolume;
        }

        public Motorcycle(string motorcycle)
            : base(motorcycle)
        {
            _vehicle = motorcycle;
        }

        public double CylinderVolume
        {
            get
            {
                return _cylinderVolume;
            }
            set
            {
                _cylinderVolume = value;
            }
        }

        public string Vehicle
        {
            get
            {
                return _vehicle;
            }
            set
            {
                _vehicle = value;
            }
        }

        public override string Stats()
        {
            Console.WriteLine($"Vehicle: {Vehicle}\nCylindervolume: {CylinderVolume}");
            return base.Stats();
        }

    }
}