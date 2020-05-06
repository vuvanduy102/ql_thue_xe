using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlythuexe
{
    class danhsachthue
    {
        private string hoten;
        private int sogiothue;
        private xe kieuxe;
        public void nhap()
        {
            Console.WriteLine("nhap vao ten nguoi thue:");
            hoten = Console.ReadLine();
            Console.WriteLine("nhap vao so gio thue:");
            sogiothue =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("nhap vao kieu thue xe: nhap 1 la xe tai, 2 la xe du lich:");
            int loaixe = Convert.ToInt32(Console.ReadLine());
            if (loaixe == 1)
                kieuxe = new xetai();
            else if (loaixe == 2)
                kieuxe = new xedulich();
        }
        public void xuat()
        {
            Console.WriteLine("ten nguoi thue:" + hoten + "so gio thue:" + sogiothue + "so tien thue:" + kieuxe.tinhtien(sogiothue));
        }
    }
}
