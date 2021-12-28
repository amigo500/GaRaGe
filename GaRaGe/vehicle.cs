using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public abstract class Vehicle : IVehicle
    {


        private string _Vehicle;
        private string _licnr;
        private string _color;
        private int _numberOfWheels;
        private double _weight;


        public Vehicle(string vehicle)
        {
            _Vehicle = vehicle;
        }

        public Vehicle(string vehicle, string licnr, string color, int numberofwheels, double weight)
        {
            _Vehicle = vehicle;
            _licnr = licnr;
            _color = color;
            _numberOfWheels = numberofwheels;
            _weight = weight;
        }

        public string Vehicle1
        {
            get
            {
                return _Vehicle;
            }

            set
            {
                _Vehicle = value;
            }

        }

        public string LicNr
        {
            get
            {
                return _licnr;
            }

            set
            {
                _licnr = value;
            }
        }


        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }


        public int NumberOfWheels
        {
            get
            {
                return _numberOfWheels;
            }
            set
            {
                _numberOfWheels = value;
            }
        }


        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }

        public virtual string Stats()
        {
            return $"Licnr: {LicNr}\nColor: {Color}\nNumber of wheels: {NumberOfWheels}\nWeight: {Weight}kg";
        }

    }
}