using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlythuexe
{
    public class xedulich:xe
    {
        public double tinhtien(int sogiothue)
        {
            double tongtien = 0;
            if (sogiothue <= 1)
                tongtien = 250000;
            else
                tongtien =Convert.ToDouble (250000 + (sogiothue - 1) * 70000);
            return tongtien;
        }
    }
}
