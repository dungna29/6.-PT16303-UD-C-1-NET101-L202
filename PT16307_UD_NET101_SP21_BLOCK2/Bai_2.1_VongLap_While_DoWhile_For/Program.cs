using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._1_VongLap_While_DoWhile_For
{
    class Program
    {
        /*
         * Bài 2.0 Vòng lặp:
         *
         * Định nghĩa chung cho tất cả vòng lặp:
         * Vòng lặp cho phép lặp lại một hoặc nhiều câu lệnh cho đến khi thỏa mãn điều kiện được chỉ định định.
         *
         * Các loại vòng lặp: while, do..while, for, foreach
         *
         * Từ khóa sử dụng trong vòng lặp:
         *
         * break - ngắt vòng lặp
         * continue: Sẽ bỏ qua các đoạn code phía sau nó và nó quay trở lại lần lặp tiếp theo.
         *
         * Vòng lặp while: Chỉ chạy khi điều kiện luôn đúng và nếu điều kiện luôn đúng ko điểm dừng thì được gọi là vòng lặp vô hạn.
         * + Cách dùng: wh + tab
         *
         * + Công thức:
         *  while (true)
            {
                //Thực thi 1 câu lệnh hoặc nhiều câu lệnh
            }
         */

        /*
        * Bài 2.1 Vòng lặp do..While khác với vòng lặp while đó là sẽ thực hiện hành động 1 lần kể cả khi while(False). Điều kiện kiện để chạy vòng lặp vẫn là While(true)
        *
        * Cách gõ: do + tab
        *
        * Công thức:
        *  do
           {
               //Thực hiện ít nhất 1 lần nếu While False             
           } while (false);
        */

        /*
         * Vòng lặp for
         *
         * Cách gõ: for + tab
         * Công thức:
         *  for (int i = 0; i < UPPER; i++)
            {
                //Thực hiện 1 hành động lặp lại 1 công việc nào đó.
            }
            int i = 0: Điểm bắt đầu của vòng lặp
            i < UPPER: Điều kiện để ngắt vòng lặp
            i++: Tăng i lên 1
         */
        static void Main(string[] args)
        {
            //While = wh + tab
            while (false)
            {
                
            }

            //do While = do + tab
            do
            {
                
            } while (false);

            //for = for + tab
            for (int i = 0; i < 10; i++)
            {
                
            }
            //In bảng cửu chương nhân 8 bằng 3 cách for, while, do while
            int a = 8;
            //Cách 1: for
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}",a,i,a*i);
            }

            //Cách 2: While
            int b = 1;
            while (b <= 10)
            {
                Console.WriteLine("{0} x {1} = {2}", a, b, a * b);
                b++;
            }

            //Cách 3: do While
            b = 1;
            do
            {
                Console.WriteLine("{0} x {1} = {2}", a, b, a * b);
                b++;
            } while (b <= 10);


            //Continue
            for (int i = 0; i < 4; i++)
            {
                
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine("Chào các bạn " + i);
                break;
            }
        }
    }
}
