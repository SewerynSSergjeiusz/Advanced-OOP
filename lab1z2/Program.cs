using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1z2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 18, Country = "Poland" },
                new Student() { StudentID = 2, StudentName = "Steve", Age = 22, Country = "Poland" },
                new Student() { StudentID = 3, StudentName = "Bill", Age = 18, Country = "USA" },
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20, Country = "USA" },
                new Student() { StudentID = 5, StudentName = "Ron", Age = 21, Country = "Germany" }
            };

            foreach (Student studentname in studentList.FindAll(e => e.Age > 18).Take(1).ToList())
            {
                Console.WriteLine("Imie najstarszego studenta: " + studentname.StudentName);
            }

            studentList.Sort(delegate (Student x, Student y)
            {
                if (x.StudentName == null && y.StudentName == null) return 0;
                else if (x.StudentName == null) return -1;
                else if (y.StudentName == null) return 1;
                else return x.StudentName.CompareTo(y.StudentName);
            });

            Console.WriteLine("Lista po sortowaniu wg imienia: ");

            foreach(Student i in studentList)
            {
                Console.WriteLine(i.StudentName);
            }

            Console.WriteLine("Lista studentów z parzystmymi StudentID: ");

            foreach (Student i in studentList)
            {
                if(i.StudentID % 2 == 0)
                {
                    Console.WriteLine(i.StudentName);
                    
                }

            }
            Console.WriteLine("Tutaj powinno pokaza sie powitanie.");
            

            foreach (Student i in studentList)
            {
                Student student = new Student();
                string x = student;
                x = i.StudentName;
                
                if (i.Country != "Germany")
                {
                    Console.WriteLine(x.Greeting());
                    
                }
            }


            /*
            foreach (Student i in studentList)
            {

                if (i.StudentName)
                Console.WriteLine(i.StudentName);
            }
            */
            Console.ReadLine();
            
        }
    }
}
