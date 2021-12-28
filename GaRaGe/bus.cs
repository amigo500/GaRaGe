using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Bus : Vehicle
    {
        private string _vehicle;
        private int _numberOfEngines;



        public Bus(string bus, int numberofengines, string licnr, string color, int numberofwheels, double weight)
            : base(bus, licnr, color, numberofwheels, weight)
        {
            _vehicle = bus;
            _numberOfEngines = numberofengines;
        }

        public Bus(string bus)
            : base(bus)
        {
            _vehicle = bus;
        }

        public int NumberOfEngines
        {
            get
            {
                return _numberOfEngines;
            }
            set
            {
                _numberOfEngines = value;
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
            Console.WriteLine($"Vehicle: {Vehicle}\nNumber of engines: {NumberOfEngines}");
            return base.Stats();
        }
    }
}