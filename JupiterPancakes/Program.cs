using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterPancakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name and weight of the candidate:");
            string[] candidate = Console.ReadLine().Split(' ');
            string name = candidate[0];
            int weight = int.Parse(candidate[1]);
            int height=CalculateHeight(name);
            Console.WriteLine("The energy at impact is :{0}", (EnergyAtImpact(weight, height)));
            if (EnergyAtImpact(weight, height) < 1500000)
            {
                Console.WriteLine("The candidate is approved");
            }
            else
            {
                Console.WriteLine("The candidate is a “Jupiter pancake”!");
            }
             
            
        }
        static int CalculateHeight(string name)
        {
            int height = 0;
            for (int i = 0; i < name.Length; i++)
            {
                height += name[i];
            }
            return height;
        }
        static double EnergyAtImpact(double weight,int height)
        {
            double energy=weight*height*24.79;
            return energy;
        }
    }
}
