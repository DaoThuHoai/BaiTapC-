using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 5 so a ,b,c,d,e  lan luot la : ");
            Console.Write(" Nhap a =  ");
            int a = int.Parse(Console.ReadLine());
            Console.Write(" Nhap b =  ");
            int b = int.Parse(Console.ReadLine());
            Console.Write(" Nhap c =  ");
            int c = int.Parse(Console.ReadLine());
            Console.Write(" Nhap d =  ");
            int d = int.Parse(Console.ReadLine());
            Console.Write(" Nhap e =  ");
            int e = int.Parse(Console.ReadLine());
            int max = a;
            if (max < b)  max=b;
            if (max < c)  max=c;
            if (max < d)  max=d;
            if (max < e)  max=e;
            int max2 = a;
            // tim max2
            if (b <max && max2 < b) max2 = b;
            if (c < max && max2 < c) max2 = c;
            if (d < max && max2 < d)  max2 = d;
            if (e < max && max2 < e)  max2 = e;
            Console.WriteLine("So lon thu 2 la : " + max2);
            Console.ReadKey();
        }
    }
}
