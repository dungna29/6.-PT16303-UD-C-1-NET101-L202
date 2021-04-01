using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_MAU_NHAP_XUAT_OOPV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            ServiceSinhVien service = new ServiceSinhVien();
            service.bai3TaoArrayDoiTuong();
            service.inMangSinhVien();
        }
    }
}
