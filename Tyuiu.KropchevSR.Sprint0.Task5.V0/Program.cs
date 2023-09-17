using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KropchevSR.Sprint0.Task5.V0.Lib;

namespace Tyuiu.KropchevSR.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(10, 5));
            Console.WriteLine("A - B = " + DataService.Substration(10, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 5));
            Console.WriteLine("A / B = " + DataService.Division(10, 0));
            Console.ReadKey();
        }
    }
}
