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
            Console.WriteLine("Hello! input your first number");
            ushort firstInteger = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Hello! input your second number");
            ushort secondInteger = ushort.Parse(Console.ReadLine());
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
                Console.WriteLine("We noticed that your first input happens to be larger than your second input");
            }
            if (firstInteger < secondInteger)
            {
                Console.WriteLine("We noticed that your second input happens to be larger than your first input");
            }
            if (firstInteger == secondInteger)
            {
                Console.WriteLine("We noticed that your inputs are equal to one another");
            }
            Console.ReadLine();
        }
    }
}
