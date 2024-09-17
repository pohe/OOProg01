using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProg01
{
    public class Human
    {
        //instance fields
        private string _name;
        private int _height;
        private int _weight;

        //properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public double BMI
        {
            get { return (_weight) / (_height/100.0 * _height/100.0); }
        }

        //constructors - initial values
        public Human() {
            _name = "NoName";
            _height = 0;
            _weight = 0;
        }


        public Human(string name, int height, int weight)
        {
            _name = name;
            _height = height;
            _weight = weight;
        }

        //methods  - access specifier returntype MethodName (parameters)
        public void PrintAllInformation()
        {
            Console.WriteLine($"Human objektet indeholder {_name} {_height} {_weight} BMI {BMI}");
        }

    }
}
