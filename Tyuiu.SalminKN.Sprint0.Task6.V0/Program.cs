using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint0.Task6.V0.Lib;

namespace Tyuiu.SalminKN.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(DataService.AddictionArray(numsArray));
            Console.WriteLine(DataService.SubstractionArray(numsArray));
            Console.WriteLine(DataService.MultiplicationArray(numsArray));
            Console.ReadLine();
        }
    }
}
