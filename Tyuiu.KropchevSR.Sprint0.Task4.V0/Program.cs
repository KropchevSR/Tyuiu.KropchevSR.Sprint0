using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KropchevSR.Sprint0.Task4.V0.Lib;


namespace Tyuiu.KropchevSR.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Substration(8, 5));
            Console.WriteLine(DataService.Multiplication(7, 5));
            Console.WriteLine(DataService.Division(10, 5));


            Console.ReadKey();
        }
    }
}
