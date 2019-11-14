using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectedRaises
{
    class Program
    {
        static void Main(string[] args)
        {
            const double projectedRaises = 1.04;
            double employeeSalary1 = 10000;
            double employeeSalary2 = 15000;
            double employeeSalary3 = 18000;

            employeeSalary1 = employeeSalary1 * projectedRaises;
            employeeSalary2 = employeeSalary2 * projectedRaises;
            employeeSalary3 = employeeSalary3 * projectedRaises;



            Console.WriteLine("Employee 1 salery is {0}", employeeSalary1);
            Console.WriteLine("Employee 2 salery is {0}", employeeSalary2);
            Console.WriteLine("Employee 3 salery is {0}", employeeSalary3);
        }
    }
}
