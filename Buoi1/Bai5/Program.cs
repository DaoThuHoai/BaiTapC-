using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen n : ");
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    k++;
                }
            }
            if (k == 2)
            {
                Console.WriteLine("Day la so nguyen to ");
            }
            else
                Console.WriteLine("Day khong phai so nguyen to ");
            Console.ReadKey();
        }
    }
}
