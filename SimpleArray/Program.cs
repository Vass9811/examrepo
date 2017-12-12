using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers:");
            string[] array = Console.ReadLine().Split(' ');
            Console.WriteLine("Enter commands:increase,swap,decrease,info");
            string[] command = Console.ReadLine().Split(' ');
            switch (command[0])
            {
                case "increase":
                    Increase(command[0], command[1]);
                    break;
                case "swap":
                    Swap();
                    break;
                case "decrease":
                    Decrease(array[1]);
                    break;
                case "info":
                    Info(array[1]);
                    break;
            }

        }
        static void Increase(string command, string value)
        {
            int counter = 0;
            for (int i = 0; i < value.Length; i++)
            {
                counter += value[i];

                Console.WriteLine("{1}-->" , i, value[i]);
            }
            Console.WriteLine("the total sum :{0}",counter);

        }
        static void Swap()
        {

        }
        static void Decrease(string array)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());

        }
        static void Info(string array)
        {
            int length = array.Length;
            Console.WriteLine("The lenght of the array is :{0}", length);
            int m = array.Max();
            Console.WriteLine("Max: {0}", m);
            int min = array.Min();
            Console.WriteLine("Min: {0}", min);
        }
    }
}
    
