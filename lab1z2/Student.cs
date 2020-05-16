using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1z2
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public void Greeting()
        {
            Console.WriteLine("hello "+ StudentName);

        }
       

        /*public string getData()
        {
            return this.StudentID +" "+ this.StudentName+" "+this.Age+" "+this.Country;
        }*/
    }
}
