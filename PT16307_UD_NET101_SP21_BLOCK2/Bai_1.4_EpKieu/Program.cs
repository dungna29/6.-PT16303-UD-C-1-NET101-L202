using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._4_EpKieu
{
    class Program
    {/*
         * P1: Ép kiểu - Chuyển đổi từ kiểu dữ liệu số sang dạng số khác - Không đổ kiểu dữ liệu lớn về bé mà chỉ bé lên lớn ví dụ int lớn hơn byte hoặc long nhất trong số nguyên. Ngoài ra các bạn có thể tham khảo lại trong bảng kích thước kiểu dữ liệu.
         *
         * Công thức ép kiểu tường minh:
         *        (<kiểu dữ liệu>) <biến cần ép kiểu>;
         *
         * P2: Ép kiểu từ string về số
         *  + Phương thức Parse()
         *  + Lớp Convert()
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string numberString1 = "5", numberString2 = "5";
            Console.WriteLine("{0} + {1} = {2}", numberString1, numberString2, numberString1 + numberString2);//Số 5 đang dạng chuỗi nên sẽ cộng chuỗi

            Console.WriteLine("Ép kiểu: {0} + {1} = {2}", numberString1, numberString2, Convert.ToInt32(numberString1) + Convert.ToInt32(numberString2));//Ép kiểu String về số


            //Phần 1: Convert
            // int number1, number2;
            // Console.WriteLine("Mời bạn nhập số 1: ");
            // number1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Mời bạn nhập số 2: ");
            // number2 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("{0} + {1} = {2}", number1, number2, number1+ number2);

            //Phần 2:
            int number1, number2;
            Console.WriteLine("Mời bạn nhập số 1: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập số 2: ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);

            //NGoài ra một vài ví dụ ép kiểu:
            double diemCsharp = Double.Parse("8.6");


            //Phần 3: Chuyển đổi kiểu dữ liệu số sang số khác
            int a = 9;
            double b = 8.6;
            //a = b;
            b = a;

            /*
            Bài 1: Chương trình cho phép nhập họ và tên sinh viên, năm sinh, mã sinh viên   từ bàn phím và xuất ra định dạng sau: 
             “Chào bạn <<họ và tên>> | <<năm sinh>>  | <<mã sinh viên>>  đến với chương trình java đầu tiên.”
            
            Bài 2: Cho người dùng nhập vào 3 đầu điểm Toán, Văn, Anh và tính điểm trung bình cho bạn đó
            */
        }
    }
}
