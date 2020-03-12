using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap n : ");
            do
            {
                n = int.Parse(Console.ReadLine());
                if(n<=0)
                Console.WriteLine("Nhap lai n ");
            } while (n <= 0);
            Console.Write(" Cac uoc chung cua no la :  ");
              for(int i=1;i<n;i++)
            {
                if(n%i==0)
                {
                    Console.Write("   "+i);
                }
            }
            Console.ReadKey();

        }
    }
}
