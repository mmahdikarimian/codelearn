using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringCase
{
    public class Task_11_3_1402
    {
        public void SumNumbers()
        {
            bool canParse1;
            int number1 = 0;
            int number2 = 0;
            bool canParse2;
            
            do
            {
                Console.WriteLine("please enter first number : ");
                string input1 = Console.ReadLine();
                canParse1 = int.TryParse(input1, out number1);
            } while (!canParse1);
            do
            {
                Console.WriteLine("please enter second number : ");
                string input2 = Console.ReadLine();
                canParse2 = int.TryParse(input2, out number2);
            } while (!canParse2);

            Console.WriteLine($"result is : {number1+number2}");
        }

        public void AdadAval()
        {

            bool canParse1;
            int inputNumber;
            int count = 1;
            bool flag;
            List<int> numbers = new List<int>();
            List<int> result = new List<int>();
            do
            {
                Console.WriteLine($"please enter {count}th number : ");
                string input1 = Console.ReadLine();
                canParse1 = int.TryParse(input1, out inputNumber);
                if (canParse1)
                {
                    numbers.Add(inputNumber);
                    count++;
                }
            } while (count<11);

            count = 0;
            foreach (int number in numbers)
            {
                flag = true;
                if (number == 1 || number ==0)
                {
                    flag = false;
                }
                for (int i = 2; i < number; i++)
                    if (number % i == 0)
                        flag = false;
                if (flag)
                {
                    count++;
                    Console.WriteLine($"{count} : {number}");
                }
            }

           

        }

        public void StudentAverages()
        {
            List<Student> students = new List<Student>();
            
            int grade;
            int gradeCounter =1;
            int studentCounter = 1;
            do
            {
                Student student = new Student();
                Console.WriteLine($"enter {studentCounter}th student");
                student.Name = Console.ReadLine();
                do
                {
                    Console.WriteLine($"enter {student.Name}s {gradeCounter}th grade");
                    grade = int.Parse(Console.ReadLine());
                    student.Grades.Add(grade);
                    gradeCounter++;
                } while (gradeCounter < 6);
                students.Add(student);
                gradeCounter = 1;
                 studentCounter++;
            } while (studentCounter < 5);


            foreach (Student student in students)
            {
                student.Average = student.Grades.Average();
            }

            students = students.OrderByDescending(x => x.Average).ToList();

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Name} : {item.Average}");
            }
            
        }
    }

    public class Student
    {
        public Student()
        {
            Grades = new List<int>();
        }

        public string Name { get; set; }
        public List<int> Grades { get; set; }
        public double Average { get; set; }

        
    }
}
