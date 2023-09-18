using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint0.Task4.V0.Lib;

namespace Tyuiu.SalminKN.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Multiplication(int.MaxValue, int.MaxValue));
            Console.WriteLine(DataService.Addiction(5, 10));
            Console.ReadKey();
        }
    }
}
