using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_MAU_CRUD_OOP_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            ServiceStudent sv = new ServiceStudent();
            string input;
            do
            {
                Console.WriteLine("1. Thêm");
                Console.WriteLine("2. Sửa");
                Console.WriteLine("3. Xóa");
                Console.WriteLine("4. Tìm kiếm");
                Console.WriteLine("5. Xuất ds");
                Console.WriteLine("6. Xuất ds đã sắp sort");
                Console.WriteLine("7. Thoát");
                Console.WriteLine("Mời bạn chọn chức năng: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        sv.addStudent();
                        break;
                    case "2":
                        sv.suaSV();
                        break;
                    case "3":
                        sv.xoaSV();
                        break;
                    case "4":
                        sv.timKiemSV();
                        break;
                    case "5":
                        sv.getListSV();
                        break;
                    case "6":
                        sv.sortListSV();
                        break;
                    case "7":
                        Console.WriteLine("Học lại nhé!");
                        break;
                    default:
                        break;
                }

            } while (!(input == "7")));
        }
    }
}
