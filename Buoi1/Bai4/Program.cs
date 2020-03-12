using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so tu nhien n : ");
            int n = int.Parse(Console.ReadLine());
            int S1 = 0,S2=1,S3=0;
            for(int i=0;i<=n;i++)
            {
                S1 += i;  
            }
            Console.WriteLine("S1 =   " + S1);
            for(int i=1;i<=n;i++)
            {
                S2 *= i;
                S3 += i * (i - 1);
            }
            Console.WriteLine("S2 =   " + S2);
            Console.WriteLine("S3 =   " + S3);

            Console.ReadKey();
        }
    }
}
