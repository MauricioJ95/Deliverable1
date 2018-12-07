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

            Console.WriteLine((num1 + num2 + num3));
            input = Console.ReadLine();
            total = float.Parse(input);

            var usCulture = CultureInfo.GetCultureInfo("en-US");
            var outputUS = string.Format("c", usCulture);

            var svCulture = CultureInfo.GetCultureInfo("sv-Sweden");
            var outputSV = string.Format("c", svCulture);

            var jaCulture = CultureInfo.GetCultureInfo("ja-Japan");
            var outputJA = string.Format("c", jaCulture);

            var thCulture = CultureInfo.GetCultureInfo("th-Thai");
            var outputTH = string.Format("c", thCulture);

            Console.WriteLine("Highest number is {0}", values.Max());
            Console.WriteLine("Lowest number is {0}", values.Min());
            Console.WriteLine("Average is {0}", values.Average());


            /*var usCulture = CultureInfo.GetCultureInfo("EN-US");

            var output = string.Format("c", usCulture);*/

            Console.ReadLine();

        }
        
    }
}
