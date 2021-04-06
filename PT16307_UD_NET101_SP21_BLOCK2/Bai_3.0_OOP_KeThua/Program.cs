using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._0_OOP_KeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tạo 3 lớp đối tượng

            /*
             * 1. SinhVien1(ten,ho,tendem,sdt,email,msv,diemJava,diemCsharp)
             * 2. GiaoVien1(ten,ho,tendem,sdt,email,mgv,gioDay)
             * 3. KeToan1(ten,ho,tendem,sdt,email,mnv,luong)
             */

            //Sử dụng 
            // SinhVien sv1 = new SinhVien();
            // sv1.Ho = "Nguyễn";
            // sv1.Tendem = "Hoàng";
            // sv1.Ten = "Long";
            // sv1.Msv = "PH00555";
            // sv1.DiemCsharp = 7;
            // sv1.DiemJava = 9;

            //Ghi đè phương thức
            Person p = new Person();
            p.inRaManHinh();
            SinhVien sv = new SinhVien();
            sv.inRaManHinh();
        }
    }
}
