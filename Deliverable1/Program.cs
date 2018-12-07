using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0, num2 = 0, num3 = 0;
            string input;

            Console.WriteLine("Please input a $ amount");
            input = Console.ReadLine();
            num1 = float.Parse(input);

            Console.WriteLine("Please input a $ amount");
            input = Console.ReadLine();
            num2 = float.Parse(input);

            Console.WriteLine("Please input a $ amount");
            input = Console.ReadLine();
            num3 = float.Parse(input);

            List<float> amount = new List<float>();
            amount.Add(num1);
            amount.Add(num2);
            amount.Add(num3);
            amount.Max();
            amount.Min();
            amount.Average();

            Console.WriteLine("Highest number is {0}", amount.Max());
            Console.WriteLine("Lowest number is {0}", amount.Min());
            Console.WriteLine("Average is {0}", amount.Average());
            Console.ReadLine();

        }
        
    }
}
