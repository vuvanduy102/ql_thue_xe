using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlythuexe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap vao so nguoi thue:");
            n = Convert.ToInt32(Console.ReadLine());
            danhsachthue[] ds = new danhsachthue[n];
            for(int i=0;i<n;i++)
            {
                ds[i] = new danhsachthue();
                ds[i].nhap();
            }
            for (int i = 0; i < n; i++)
            {
                ds[i].xuat();
            }
            Console.ReadLine();
        }
    }
}
