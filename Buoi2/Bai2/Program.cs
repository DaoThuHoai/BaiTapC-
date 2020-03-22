using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Input( out double a,out double x, out int n )
        {
            Console.Write("Nhap so thuc a : ");
            a = double.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhap so thuc x : ");
                x = double.Parse(Console.ReadLine());
            } while (x <= 0);
            do
            {
                Console.Write("Nhap so nguyen n thoa man 5<=n<=12 : " );
                n = int.Parse(Console.ReadLine());
            } while (n < 5 || n > 12);
        }
        static double Tinhxk(double x,int k )
        {
            return Math.Sqrt(Math.Pow(x, k));
        }
       static double tinh(double a,double x,int n )
        {
            double S = 0;
            int k =0;
            S += a + Math.Pow(-1, n) * Tinhxk(x, k++) / n--;
            return S;
        }
        static void Main(string[] args)
        {
            double a, x;
            int n;
            Input(out a,out x,out n);
            Console.WriteLine("Gia tri S = " + tinh(a, x, n));
            Console.ReadKey();
        }
    }
}
