using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace descrit_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inter your frist number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("inter your second number");
            int num2 = int.Parse(Console.ReadLine());

            for(int num = num1; num < num2; num++) { 
            decimal sum =0;
                for(int i = 1 ; i<num ; i++)
                {
                    if(num%i==0) { sum = sum + i; }
                }
                if (sum == num) { Console.WriteLine(num); }
                Console.ReadKey();
            
            }
        }
    }
}
