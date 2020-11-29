using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_four_task_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to your sum checker");
            Console.WriteLine("Please input your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please input your sex (male or female)");
            string sex = Console.ReadLine();
            sex = sex.ToLower();
            string option1 = "male";
            string option2 = "female";
            DateTime time = DateTime.Now;
            bool afternoon = time.Hour >= 12;
            bool morning = time.Hour <= 12;
            bool evening = time.Hour >= 18;


            if ((sex == option1) && (afternoon))
            {
                Console.WriteLine($"Good afternoon Mr. {name}");
            }

            else if ((sex == option1) && (morning))
            {
                Console.WriteLine($"Good morning Mr. {name}");
            }

            else if ((sex == option1) && (evening))
            {
                Console.WriteLine($"Good evening Mr. {name}");
            }

            else if (sex == option2)
            {
                Console.WriteLine("Are you single or married?");
                string maritalStatus = Console.ReadLine();
                string status1 = "single";
                string status2 = "married";

                if ((maritalStatus == status1) && (afternoon))
                {
                    Console.WriteLine($"Good afternoon Miss. {name}");
                }

                else if ((maritalStatus == status1) && (morning))
                {
                    Console.WriteLine($"Good morning Miss. {name}");
                }

                else if ((maritalStatus == status1) && (evening))
                {
                    Console.WriteLine($"Good evening Miss. {name}");
                }

                else if ((maritalStatus == status2) && (afternoon))
                {
                    Console.WriteLine($"Good afternoon Mrs. {name}");
                }

                else if ((maritalStatus == status2) && (morning))
                {
                    Console.WriteLine($"Good morning Mrs. {name}");
                }

                else if ((maritalStatus == status2) && (evening))
                {
                    Console.WriteLine($"Good evening Mrs. {name}");
                }
            }

            Console.WriteLine($"{name} please input your first number");
            ushort firstInteger = ushort.Parse(Console.ReadLine());
            Console.WriteLine($"{name} please input your second number");
            ushort secondInteger = ushort.Parse(Console.ReadLine());
            DateTime startTime = DateTime.Now;
            if ((firstInteger + secondInteger) == 30 || (firstInteger) == 30 || (secondInteger) == 30)
            {
                Console.WriteLine("True, the sum of your input is equal to 30");
            }
            else
            {
                Console.WriteLine("The sum of your inputs are not equal to 30");
            }
            if (firstInteger > secondInteger)
            {
                Console.WriteLine($"{name} we noticed that your first input ({firstInteger}) happens to be larger than your second input ({secondInteger}) with a difference of {firstInteger - secondInteger}");
            }
            if (firstInteger < secondInteger)
            {
                Console.WriteLine($"{name} we noticed that your second input ({secondInteger}) happens to be larger than your first input ({firstInteger}) with a difference of {secondInteger - firstInteger}");
            }
            if (firstInteger == secondInteger)
            {
                Console.WriteLine($"{name} we noticed that your inputs are equal to one another");
            }
            DateTime endTime = DateTime.Now;

            TimeSpan responseTime = startTime - endTime;

            double resultTime = responseTime.TotalMilliseconds;

            Console.WriteLine($"{name} It took {resultTime} milliseconds to deliver your results, \nWe hope you're impressed");
            if ((afternoon) && (sex == option1))
            {
                Console.WriteLine($"Have a lovely afternoon Mr. {name}");
            }

            else if ((morning) && (sex == option1))
            {
                Console.WriteLine($"Have a lovely morning Mr. {name}");
            }

            else if ((evening) && (sex == option1))
            {
                Console.WriteLine($"Have a lovely evening Mr. {name}");
            }


            else if ((morning) && (sex == option2))
            {
                Console.WriteLine("Have a lovely morning Ma'am");
            }

            else if ((afternoon) && (sex == option2))
            {
                Console.WriteLine($"Have a lovely afternoon Ma'am");
            }

            else if ((evening) && (sex == option2))
            {
                Console.WriteLine($"Have a lovely evening Ma'am");
            }


            Console.ReadLine();
        }
    }
}
