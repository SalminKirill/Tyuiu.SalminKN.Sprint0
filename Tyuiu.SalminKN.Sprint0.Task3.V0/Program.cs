﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SalminKN.Sprint0.Task3.V0.Lib;

namespace Tyuiu.SalminKN.Sprint0.Task3.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Sum(int.MaxValue, int.MinValue)) ;
            Console.ReadKey();
        }
    }
}
