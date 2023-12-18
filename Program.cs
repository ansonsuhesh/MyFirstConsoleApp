using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperatorExamples();
        }

        private static void OperatorExamples()
        {
            int width = 3;
            width++;
            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);
            Console.ReadLine();

            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);
            Console.ReadLine();

            bool truthValue = true;
            Console.WriteLine(truthValue);
            Console.ReadLine();

        }
    }
}
