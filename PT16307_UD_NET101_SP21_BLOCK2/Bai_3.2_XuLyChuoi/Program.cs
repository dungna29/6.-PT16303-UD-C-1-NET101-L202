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
            string s1 = "Cao Dang Thuc Hanh FPT";
            string s2 = "FPT";
            bool b = s1.Contains(s2);//Chỉ cần tìm thấy FPT trong chuỗi 1 sẽ trả ra true
            Console.WriteLine(b);

            //3. 
            string[] arrName = {"Nguyen Van A", "Nguyen Van B", "Tran Thi Trang", "Hoang Thi Trang"};
            foreach (var x in arrName.Where(c=>c.StartsWith("Nguyen Van A")))
            {
                Console.WriteLine(x);
            }
        }
    }
}
