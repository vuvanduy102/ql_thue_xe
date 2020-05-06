using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlythuexe
{
    public class xetai:xe
    {
        public double tinhtien(int sogiothue)
        {
            double tongtien = 0;
            if (sogiothue <= 1)
                tongtien = 220000;
            else
                tongtien = Convert.ToDouble(220000 + (sogiothue - 1) * 85000);
            return tongtien;
        }
    }
}
