using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectedRaisesInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PREDICTED_RAISES = 1.04;
            double employeeSalary1 = 25,000;
            double employeeSalary2 = 30,000;
            double employeeSalary3 = 32,000;

            Console.WriteLine("What is employee 1's salary this year >>>");
            employeeSalary1 = Convert.ToDouble(Console.ReadLine());
            calculateRaise(employeeSalary1, PREDICTED_RAISES, 1);

            Console.WriteLine("What is employee 2's salary this year >>>");
            employeeSalary2 = Convert.ToDouble(Console.ReadLine());
            calculateRaise(employeeSalary2, PREDICTED_RAISES, 2);

            Console.WriteLine("What is employee 3's salary this year >>>");
            employeeSalary3 = Convert.ToDouble(Console.ReadLine());
            calculateRaise(employeeSalary3, PREDICTED_RAISES, 3);


        }

        public static void calculateRaise(double raise, double salary, int empNum)
        {

            employeeSalary1 = employeeSalary1 * PREDICTED_RAISES;
            employeeSalary2 = employeeSalary2 * PREDICTED_RAISES;
            employeeSalary3 = employeeSalary3 * PREDICTED_RAISES;



            Console.WriteLine("Employee 1 salery is {0}", employeeSalary1);
            Console.WriteLine("Employee 2 salery is {0}", employeeSalary2);
            Console.WriteLine("Employee 3 salery is {0}", employeeSalary3);
        }
    }
}
