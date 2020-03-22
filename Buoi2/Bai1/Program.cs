using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
       static void Input (out int n )
        {
             n = int.Parse(Console.ReadLine());            
        }
        static void Inputarr(int [] arr ,int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.Write("Nhap a[" + i + "]= ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        static bool snt (int k)
        {
            bool check = true;
            if( k<2)
            {
                check = false;
                return check;
            }
            for(int i=2;i<=Math.Sqrt(k);i++)
            {
                if(k%i==0)
                {
                    check= false;
                    break;
                }
            }
            return check;
        }
        static void Output(int [] arr,int n )
        {
            for(int i=0;i<n;i++)
            {
                if(snt (arr[i]))
                {
                    Console.Write(arr[i] + "    ");
                }
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so nguyen n : ");
            Input(out n );
            int[] arr = new int[n];
            Inputarr(arr,  n);
            Output(arr, n);

            Console.ReadKey();
        }
    }
}
