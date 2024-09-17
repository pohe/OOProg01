using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProg01
{
    public class Customer
    {
        //instance fields

        private string _name;
        private string _tlf;
        private bool _isBlacklisted = false;

        //properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Adr
        {
            get;
            set;
        }

        public string Tlf
        {
            get { return _tlf; }
            set { _tlf = value; }
        }

        public bool IsBlacklisted
        {
            get { return _isBlacklisted; }
        }

        //constructors
        public Customer(string name, string adr, string tlf)
        {
            _name = name;
            Adr = adr;
            _tlf = tlf;
            //_isBlacklisted = false;
        }


        //methods
        public void Blacklist()
        {
            _isBlacklisted = true;
        }

        public void CustomerInfo()
        {
            if (!_isBlacklisted)
            {
                Console.WriteLine($"Navn: {_name}\n Adresse: {Adr}\n telefon: {_tlf}");
            }
            else
            {
                Console.WriteLine($"Navn: {_name} er smidt ud af butikken!");
            }

        }

    }
}
