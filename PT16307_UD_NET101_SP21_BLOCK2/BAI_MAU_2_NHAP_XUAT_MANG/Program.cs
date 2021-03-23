using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_MAU_2_NHAP_XUAT_MANG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string[] arrNames;
            int sizeArr;
            Console.WriteLine("Mời bạn nhập số lượng tên: ");
            sizeArr = Convert.ToInt32(Console.ReadLine());//Lấy được kích thước do người dùng nhập vào
            arrNames = new string[sizeArr];//Khởi tạo 1 mảng có kích thước do người dùng nhập vào

            for (int i = 0; i < sizeArr; i++)
            {
                Console.WriteLine("Mời bạn nhập tên thứ: " + i );
                arrNames[i] = Console.ReadLine();//Gán giá trị cho mảng theo index
            }

            foreach (var x in arrNames)
            {
                Console.Write(x + " ");
            }
        }
    }
}
