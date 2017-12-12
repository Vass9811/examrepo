using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainingStations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option:");
            Console.WriteLine("1-->Sofia station");
            Console.WriteLine("2-->Plovdiv station");
            Console.WriteLine("3-->Burgas station");
            Console.WriteLine("Enter your choice here:");
            string option = Console.ReadLine();
            double[] sofia = new double[12];
            double[] plovdiv = new double[12];
            double[] burgas = new double[12];

            switch (option)
            {
                case "1":
                    Console.WriteLine("You chose Sofia.Congrats!");
                    PrintMonths(sofia);
                    Console.WriteLine("The average amount is {0}",Average(sofia));
                    Checks(sofia);
                    break;
                case "2":
                    Console.WriteLine("You chose Sofia.Congrats!");
                    PrintMonths(plovdiv);
                    Console.WriteLine("The average amount is {0}", Average(plovdiv));
                    Checks(plovdiv);
                    break;
                case "3":
                    Console.WriteLine("You chose Sofia.Congrats!");
                    PrintMonths(burgas);
                    Console.WriteLine("The average amount is {0}", Average(burgas));
                    Checks(burgas);
                    break;
                 

            }
            
        }
        static void PrintMonths(double[]a)
        {
            Random random = new Random();
            double raining = random.Next(0, 200);
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine("{0}'s raining is {1} mm/mm2",months[i],raining);
            }
        }

        static double Average(double[] raining)
        {
            Console.WriteLine("------------------------------------");
            double average = 0;
            int br = 0;
            for (int i = 0; i < raining.Length; i++)
            {
                average += raining[i];
                ++br;
            }
            return average / br;
        }
        static void Checks(double[]a)
        {
            Console.WriteLine("---------------------------------");
            string[] months = new string[] { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "Octomber", "November", "December" };
            int count = 0;
            for (int i = 0; i <a.Length; i++)
            {
                if (a[i] > 76 && a[i] % 7 == 0)
                {
                    Console.WriteLine("{0} rainings have more than 76 and can be devided by 7 without reminder", months[i]);
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("There is no months that are more than 76 and can be devided by 7 without reminder");
            }
        }
    }
}
