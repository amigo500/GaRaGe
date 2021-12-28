using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Boat : Vehicle
    {
        private string _vehicle;
        private double _length;



        public Boat(string boat, double length, string licnr, string color, int numberofwheels, double weight)
            : base(boat, licnr, color, numberofwheels, weight)
        {
            _vehicle = boat;
            _length = length;
        }

        public Boat(string boat)
            : base(boat)
        {
            _vehicle = boat;
        }


        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
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
            Console.WriteLine($"Vehicle: {Vehicle}\nLength: {Length}");
            return base.Stats();
        }

    }
}