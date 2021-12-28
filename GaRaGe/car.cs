using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Car : Vehicle
    {

        private string _vehicle;
        private string _brand;
        private string _fuelType;


        public Car(string car, string Brand, string fueltype, string licnr, string color, int numberofwheels, double weight)
            : base(car, licnr, color, numberofwheels, weight)
        {
            _vehicle = car;
            _brand = Brand;
            _fuelType = fueltype;
        }

        public Car(string car)
            : base(car)
        {
            _vehicle = car;
        }


        public string FuelType
        {
            get
            {
                return _fuelType;
            }
            set
            {
                _fuelType = value;
            }
        }

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
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
            Console.WriteLine($"Vehicle: {Vehicle}\nBrand: {Brand}\nFueltype: {FuelType}");
            return base.Stats();
        }

    }
}