using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen n : ");
            int n = int.Parse(Console.ReadLine());
            int k = 2;
            Console.Write(n + " = ");
            while(n!=1)
            {
                if (n % k == 0)
                {
                    if (n == k)
                    {
                        Console.Write(k);
                    }

                    else
                    {  
                        Console.Write(k + "  x  ");
                    }
                    n /= k;
                }
                else
                    k++;
            }
            Console.ReadKey();
        }
    }
}
