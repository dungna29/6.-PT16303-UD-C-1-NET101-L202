using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_MAU_1_NHAP_XUAT
{
    class Program
    {
        // Bài 1: Chương trình cho phép nhập họ và tên sinh viên, năm sinh, mã sinh viên từ bàn phím và xuất ra định dạng sau: 
        // “Chào bạn <<họ và tên>> | <<năm sinh>>  | <<mã sinh viên>>  đến với chương trình java đầu tiên.”
        static void Main(string[] args)
        {
            //Bước 1: Xác định cần bao nhiêu biến ?
            string name, msv;
            int year;

            //Bước 2: Triển khai
            Console.Write("Tên bạn làm gì: ");
            name = Console.ReadLine();
            Console.Write("Mã bạn làm gì: ");
            msv = Console.ReadLine();
            Console.Write("Năm sinh bạn làm gì: ");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Mời bạn nhập điểm");
            double diem = Convert.ToDouble(Console.ReadLine());
            //Bước 3: Xuất ra màn hình
            Console.WriteLine("Tên: {0} Năm sinh: {1} Mã: {2}",name,msv,year);
        }
    }
}
