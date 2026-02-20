using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsolation_Assignment_02
{
    internal class Student
    {
        public string _Name { get; set; }
        private int age;
        public int getAge()
        {

            return age;
        }

        //public void setAge(int value)
        //{
        //    if(value > 18)
        //    {
        //        age = value;
        //    }

        //}
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 18)
                {
                    age = value;
                }
            }

        }
        public int AgeAfter_10_years => age + 10;
    }
}
