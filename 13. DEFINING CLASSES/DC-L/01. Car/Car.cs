using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Car
{
    public class Car
    {
        private int year;
        public string Make { get; set; }
        public string Model { get; set; }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public Car()
        {
            year = 1;
        }
        public Car(int year)
        {
            this.year = year;
        }
        public int RealAge()
        {
            return year;
        }
        public void GetOlder(int years)
        {
            year += years;
        }
    }
}
