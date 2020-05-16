using System;
using System.Collections.Generic;

namespace lab1zad2
{

    public class Student
    {

        public string studentname;
    
        public string StudentName()
        {
            return this.studentname;
        }

            

    }


    class Program
    {

        static void Main()
        {

            List<Student> studentList = new List<Student>()
            {
                studentList.Add(new Student());
            studentList[0].studentname = "John";
            studentList[1].studentname = "Sarah";
        };

            foreach (var i in studentList)
            {
                Console.WriteLine(i.studentname);
            }
        }

    }
}
        
    

