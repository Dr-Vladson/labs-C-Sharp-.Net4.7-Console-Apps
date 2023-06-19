using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Student
    {
        private string _name;
        private string _surname;
        private int _reportCardNumber;
        private double _averageMark;
        public Student (string name, string surname, int reportCardNumber, double averageMark)
        {
            if (name == null || name.Contains(" ")) _name = "Вася";
            else _name = name;

            if (surname == null || surname.Contains(" ")) _surname = "Пупкін";
            else _surname = surname;

            if (reportCardNumber <= 0) _reportCardNumber = -1;
            else _reportCardNumber = reportCardNumber;

            if (averageMark > 100 || averageMark < 60) _averageMark = 60;
            else _averageMark = averageMark;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!(value == null || value.Contains(" "))) _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (!(value == null || value.Contains(" "))) _surname = value;
            }
        }
        public int ReportCardName
        {
            get
            {
                return _reportCardNumber;
            }
            set
            {
                if (!(value <= 0)) _reportCardNumber = value;
            }
        }
        public double AverageMark
        {
            get
            {
                return _averageMark;
            }
            set
            {
                if (!(value > 100 || value < 60)) _averageMark = value;
            }
        }
    }
}
