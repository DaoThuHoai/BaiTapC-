using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 3 canh cua tam giac lan luot la : ");
            Console.Write("Nhap a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Nhap c = ");
            float c = float.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && c + a > b)
            {
                if (a == b && b == c && c == a)
                {
                    Console.WriteLine("day la tam giac deu ");
                }
                else if (a * a + b * b == c * c || b * b + c * c == a * a || a * a + c * c == b * b)
                {
                        if (a == b || b == c || c == a)
                        {
                            Console.Write("Day la tam giac vuong can ");
                        }
                        else
                            Console.Write(" Day la tam giac vuong ");
                }
                 else if( a==b||b==c||c==a)
                {
                    Console.Write("Day la tam giac can ");
                }
                else
                {
                    Console.Write("day la tam giac thuong ");
                }
            }
            else
                Console.WriteLine(" Khong phai la tam giac ");
            Console.ReadKey();
        }
    }
}
