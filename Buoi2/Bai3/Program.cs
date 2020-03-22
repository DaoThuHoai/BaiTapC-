using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static string[] a;
        static void Chuoi (string s)
        {
            a = s.Split(' ');
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+";");
            }
        }
        
        static int Tuoi()
        {
           return  DateTime.Now.Year - int.Parse(a[a.Length - 1]);
        }
        static void HienThi()
        {
            Console.WriteLine("Ho : "+ a[0]);
            Console.WriteLine("Ten Dem: "+ a[1]);
            Console.WriteLine("Ten: "+ a[2]);
            Console.WriteLine("Nam Sinh: "+ a[3]);
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi : ");
            String s=Console.ReadLine();
            Console.Write("arr = ");
            Chuoi(s);
            Console.WriteLine();
            HienThi();
            Console.WriteLine("Tuoi hien tai : " + Tuoi());
            Console.ReadKey();
        }
    }
}
