using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3KT5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give 5 students information ");
            Student[] student = new Student[5];

            for (int i = 0;i < 5;)
            {
                
                
                    Console.Write("Student name ");
                    student[i].Name = Console.ReadLine();
                    
                    Console.Write("Student Age ");
                    student[i].Age = int.Parse(Console.ReadLine());

                    Console.Write("Student School ");
                    student[i].School = Console.ReadLine();

                    Console.Write("Student Address ");
                    student[i].Address = Console.ReadLine();


                i++;
            }

            for (int i = 0;i<5;i++)
            Console.WriteLine("Name = ", student[i].Name, student[i].Age);

        }
    }
}
