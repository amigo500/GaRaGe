using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Garage<T> : IGarage, IEnumerable<T> where T : Vehicle

    {

        private T[] _vehicle;
        private int _Count = 0;
        private int _capacity;


        public Garage(int capacity)
        {

            _vehicle = new T[capacity];
            _capacity = capacity;

        }

        public T this[int index] 
        {
            get
            {
                return _vehicle[index];
            }
            set
            {
                _vehicle[index] = value;
                _Count++;
            }
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }

            set
            {
                _vehicle = new T[value];
                _capacity = value;
            }

        }


        public void DecreaseCount(int dec)
        {
            _Count -= dec;
        }

        public int Count()
        {
            return _Count;
        }


        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_vehicle).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)_vehicle).GetEnumerator();
        }



        internal void Park(T vehicle)
        {
            if (_Count <= Capacity)
            {
                for (int i = 0; i < _vehicle.Length; i++)
                {

                    if (_vehicle[i] == null)
                    {
                        _vehicle[i] = vehicle;
                        _Count++;
                        break;
                    }

                }
            }
            else
            {
                Console.WriteLine("Garage is full.");
            }

        }


    }
}