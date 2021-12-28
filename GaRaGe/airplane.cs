using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Airplane : Vehicle
    {
        private int _numberOfSeats;
        private string _vehicle;



        public Airplane(string airplane, int numbSeats, string licnr, string color, int numberofwheels, double weight)
            : base(airplane, licnr, color, numberofwheels, weight)
        {
            _vehicle = airplane;
            _numberOfSeats = numbSeats;
        }

        public Airplane(string airplane)
            : base(airplane)
        {
            _vehicle = airplane;
        }


        public int NumberOfSeats
        {
            get
            {
                return _numberOfSeats;
            }
            set
            {
                _numberOfSeats = value;
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
            Console.WriteLine($"Vehicle: {_vehicle}\nNumber of Seats: {NumberOfSeats}");
            return base.Stats();
        }

    }
}