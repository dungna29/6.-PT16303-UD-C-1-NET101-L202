using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._2_XuLyChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            // do
            // {
            //     Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //     // string id = "admin 1", pass = "123", inputID, inputPass;
            //     // Console.WriteLine("ID = ");
            //     // inputID = Console.ReadLine();
            //     // Console.WriteLine("Pass = ");
            //     // inputPass = Console.ReadLine();
            //     //1. Đây là so sánh tuyệt đối
            //     // if (inputID == id && inputPass == pass)
            //     // {
            //     //     Console.WriteLine("Đăng nhập thành công");
            //     //     return;
            //     // }
            //     //2. Contains
            //     // if (inputID.Contains(id) && inputPass.Contains(pass))
            //     // {
            //     //     Console.WriteLine("Đăng nhập thành công");
            //     //     return;
            //     // }
            //    
            //     //Console.WriteLine("Đăng nhập thât bại"); 
            // } while (false);

            //2. Contains dùng để so sánh tương đối trong lập trình
            // string s1 = "Cao Dang Thuc Hanh FPT";
            // string s2 = "FPT";
            // bool b = s1.Contains(s2);//Chỉ cần tìm thấy FPT trong chuỗi 1 sẽ trả ra true
            // Console.WriteLine(b);
            //
            // //3. 
            // string[] arrName = {"Nguyen Van A", "Nguyen Van B", "Tran Thi Trang", "Hoang Thi Trang"};
            // foreach (var x in arrName.Where(c=>c.StartsWith("Nguyen Van A")))
            // {
            //     Console.WriteLine(x);
            // }
            method1();
        }


        static void method1()
        {
            /*
             * Mời người dùng nhập vào Tên - Năm Sinh - Giới Tính
             *
             * Xuất màn hình:
             * Chào <Anh/Chị/Em/Bạn> <Tên>
             *
             * Chỉ 1 dòng code  + 1 điểm khi đi thi
             */
            while (true)
            {
                string ten, gioitinh;
                int nsBanThan = 2000,ns;
                Console.WriteLine("Mời bạn nhập tên: ");
                ten = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập giới tính: ");
                gioitinh = Console.ReadLine(); 
                Console.WriteLine("Mời bạn nhập năm sinh: ");
                ns = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Chào {0} {1}", (nsBanThan > ns && gioitinh == "nam")?"Anh"
                    : (nsBanThan > ns && gioitinh == "nu") ? "Chị"
                    : (nsBanThan < ns) ? "Em":"Bạn",ten);
            }

        }
    }
}
