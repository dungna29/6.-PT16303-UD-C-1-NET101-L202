using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._9_Method_PhuongThuc
{
    class PhuongThucKhongTraVe
    {
        /*
        *  Phương thức không trả về là : Void
        *   Công thức chung:
        *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
        *  {
        *          Body code
        *  }
        */

        //Phần 1:Phương thức không trả về không tham số
        public void tinhTong()//() không tham số
        {
            int a, b;
            Console.WriteLine("Mời bạn nhập số thứ 1: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập số thứ 2: ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Tổng 2 số: " + (a+b));
        }

        //Phần 2: Phương thức không trả về có tham số
        // public void tinhTong() Không thể đặt tên trùng với tên phương thức đã tồn tại
        // {
        //
        // }
        
        //VỀ ĐỌC TÍNH ĐA HÌNH NẠP CHỒNG PHƯƠNG THỨC TRONG FILE LÝ THUYẾT THẦY

        public void tinhTong(int a, int b)
        {
            Console.WriteLine("Tổng 2 số: " + (a + b));
        }
        public void tinhTong(int a, int b,int c)
        {
            Console.WriteLine("Tổng 3 số: " + (a + b + c));
        }
        public void tinhTong(int a, int b, int c, int d)
        {
            Console.WriteLine("Tổng 4 số: " + (a + b + c + d));
        }

        //1 Vài ví dụ về tham số
        public void method1(string a, SinhVien sv, SinhVien[] arrSinhViens,List<SinhVien> lstSinhViens) 
        {

        }
    }
}
