using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProg01
{
    public class Student
    {
        //instance fields
        private int _sno;
        private string _name;
        private string _dob;
        private int _courseNo;

        //properties
        public int Sno
        {
            get { return _sno; }
            set { _sno = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Address { get; set; }
        public string Mobile { get; set; }

        public string Email { get; set; }

        public int CourseNo
        {
            get { return _courseNo; }
            set { _courseNo = value; }
        }

        public string DOB
        {
            get { return _dob; }
            set { _dob = value; }
        }

        //constructors
        public Student(string name, int sno, int courseNo, string dob, string address, string mobile, string email)
        {
            _name = name;
            _sno = sno;
            _courseNo = courseNo;
            _dob = dob;
            Address = address;
            Mobile = mobile;
            Email = email;
        }

        //methods
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Sno: {0}", _sno);
            Console.WriteLine("CourseNo: {0}", _courseNo);
            Console.WriteLine("DOB: {0}", _dob);
            Console.WriteLine("Address: {0}", Address);
            Console.WriteLine("Mobile: {0}", Mobile);
            Console.WriteLine("Email: {0}", Email);
        }


    }
}
