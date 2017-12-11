using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter number: ");
            int fact = Convert.ToInt32(Console.ReadLine());
            for (int i = fact - 1; i >= 1; i--)
			{
                num = fact * i;
			}
            Console.WriteLine("Factorial is:    " + num);

            Console.ReadKey();
        }
    }
}
