using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0, num2 = 0, num3 = 0, total = 0;
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

            List<float> values = new List<float>();
            values.Add(num1);
            values.Add(num2);
            values.Add(num3);

            Console.WriteLine("This is the sum of the values: " + values.Sum());

            var usCulture = CultureInfo.GetCultureInfo("en-US");
            var outputUS = values.Sum().ToString("c", usCulture);
            Console.WriteLine(outputUS);


            var svCulture = CultureInfo.GetCultureInfo("sv");
            var outputSV = values.Sum().ToString("c", svCulture);
            Console.WriteLine(outputSV);

            var jaCulture = CultureInfo.GetCultureInfo("ja");
            var outputJA = values.Sum().ToString("c", jaCulture);
            Console.WriteLine(outputJA);

            var thCulture = CultureInfo.GetCultureInfo("th-TH");
            var outputTH = values.Sum().ToString("c", thCulture);

            Console.WriteLine(outputTH);
            Console.WriteLine("Highest number is {0}", values.Max());
            Console.WriteLine("Lowest number is {0}", values.Min());
            Console.WriteLine("Average is {0}", values.Average());

            Console.ReadLine();

        }
        
    }
}
