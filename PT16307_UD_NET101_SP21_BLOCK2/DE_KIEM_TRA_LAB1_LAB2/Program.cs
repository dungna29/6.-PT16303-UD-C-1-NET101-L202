using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_KIEM_TRA_LAB1_LAB2
{
    class Program
    {
        /*
        * Bài tập ôn tập tổng hợp:
        * Viết 1 chương trình có menu sử dụng switch case và vòng lặp:
        *         ------Chương trình 1-------
        *       1. In bảng cửu chương đơn
        *       2. In bảng cửu theo khoảng
        *       3. Kiểm tra học lực Sinh Viên Poly
        *       4. Nhập thông tin người yêu cũ
        *       5. Thoát.

        * Giải thích:
        *1. In bảng cửu chương đơn: Mời người dùng nhập vào tên 1 bảng cửu chương mà họ muốn sau đó in ra màn hình.

        *2. In bảng cửu theo khoảng: Mời người dùng nhập vào tên bảng cửu chương theo khoảng. Ví dụ: từ bảng nhân 5 đến nhân 8.

        *3. Kiểm tra học lực Sinh Viên Poly: Cho sinh viên POLY nhập vào điểm tổng kết môn C# và thông báo xếp loại học lực:
        *  diem<=5 --> Yếu
        *  diem<=7 --> Khá 
        *  diem<=8 --> Tiên Tiến
        *  diem<=9 --> Giỏi
        *  diem<=10 --> Xuất sắc

        *  4. Nhập thông tin nhiều người yêu cũ: Nhập các thông tin của NY Cũ thông tin sau: Tên, Năm Sinh, Giới tính, Chiều cao (Sử dụng mảng)
        * - Tên người yêu:
        * - Năm sinh:
        * - Tuổi người yêu:         
        * - Giới tính:            
        * - Chiều cao:          

       THANG ĐIỂM LẤY ĐIỂM LAB:
       - Làm đủ và đúng các mục đề bài đưa ra là: 8 điểm
       - Clean Code + || - 1 ĐIỂM
       - Áp dụng được kiến thức của đầu bài đưa ra + || - 1 Điểm
       - Copy bài có sẵn hoặc copy code ở bài cũ vào mặc định 0 điểm.
        */
        static string input;
        static string[] arrNames;
        static int[] arrYears;
        static void Main(string[] args)
        {
            while (true)
            {
                //Bước 1: Xác định biến
                Console.WriteLine("1. Thêm thông tin");
                Console.WriteLine("2. Xuất thông tin");
                Console.WriteLine("Mời bạn chọn chức năng: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        nhapVao();
                        break;
                    case "2":
                        inRa();
                        break;
                    default:
                        break;
                }
            }

        }

        static void nhapVao()
        {
            Console.WriteLine("Bạn muốn bao nhiêu phần tử: ");
            input = Console.ReadLine();
            arrNames = new string[Convert.ToInt32(input)];
            arrYears = new int[Convert.ToInt32(input)];
            for (int i = 0; i < Convert.ToInt32(input); i++)
            {
                Console.WriteLine("Mời bạn nhập tên: ");
                arrNames[i] = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập năm sinh: ");
                arrYears[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void inRa()
        {
            if (arrNames.Length < 0)
            {
                return;
            }
            for (int i = 0; i < arrNames.Length; i++)
            {
                Console.WriteLine(arrNames[i] + arrYears[i]);
            }
        }

    }
}
