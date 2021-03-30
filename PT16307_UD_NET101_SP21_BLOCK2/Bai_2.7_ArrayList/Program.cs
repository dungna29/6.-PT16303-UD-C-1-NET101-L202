using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._7_ArrayList
{
    class Program
    {/*
         *  ArrayList
         *  Định nghĩa: Là một Collections giúp lưu trữ và quản lý một
                        danh sách các đối tượng theo kiểu mảng (truy
                        cập các phần tử bên trong thông qua chỉ số
                        index)
            Ưu điểm:    Cho phép thêm hoặc xoá các phần tử một cách
                        linh hoạt và có thể tự điều chỉnh kích cỡ một
                        cách tự động.
            Sử dụng:    Để sử dụng các Collections trong .NET ta cần
                        thêm thư viện System.Collections

            Từ khóa: ArrayList arrLst<Tên> =  new ArrayList();
         */

        /*
          * A. CÁC PHƯƠNG THỨC TRONG ArrayList
          * 1. Add(object Value): Thêm đối tượng vào cuối.
          * 2. AddRange(ListObject): Thêm danh danh sách vào cuối.
          * 3. BinarySearch(object Value): Tìm kiếm value trong danh sách. Nếu tìm thấy sẽ trả lại index và không tìm thấy thì trả lại index âm. Để sử dụng danh sách phải sắp xếp.
          * 4. Clear(): Xóa tất cả các phần tử.
          * 5. Clone(): Tạo 1 bản sao của danh sách đó.
          * 6. Contains(object Value): Kiểm tra đối tượng value có tồn tại trong danh sách hay không? - Trả ra true hoặc false
          * 7. Getrange(int StartIndex, int EndIndex): Trả về 1 danh sách bao gồm các phần tử từ điểm được chỉ định.
          * 8. IndexOf(object Value): Trả về vị trí đầu tiên xuất hiện trong danh sách và nếu không tìm thấy trả về -1.
          */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Array phải khởi tạo trước kích thước ban đầu và có kiểu dữ liệu
            int[] arrNumber = new int[5];

            //ArrayList dùng để lưu trữ và không định kiểu

            //Phần 1: Khai báo và khởi tạo
            ArrayList arrLstKhongDinhKieu;//Khai báo
            arrLstKhongDinhKieu = new ArrayList();//Khởi tạo ArrayList

            //Phần 2: Thêm phần tử vào ArrayList
            arrLstKhongDinhKieu.Add(1);
            arrLstKhongDinhKieu.Add(1.6);
            arrLstKhongDinhKieu.Add('a');
            arrLstKhongDinhKieu.Add(true);
            arrLstKhongDinhKieu.Add(false);
            arrLstKhongDinhKieu.Add("C#1");

            //Phần 3: Lấy giá trị từ ArrayList
            Console.WriteLine(arrLstKhongDinhKieu[0]);//Lấy giá trị từ index
            for (int i = 0; i < arrLstKhongDinhKieu.Count; i++)
            {
                Console.Write(arrLstKhongDinhKieu[i] + " | ");
            }

            Console.WriteLine();

            //Phần 4: Xóa phần từ khỏi Arraylist
            arrLstKhongDinhKieu.RemoveAt(0);//RemoveAt dùng đễ xóa phần tử khỏi ArrayList theo index
            for (int i = 0; i < arrLstKhongDinhKieu.Count; i++)
            {
                Console.Write(arrLstKhongDinhKieu[i] + " | ");
            }
            //Một vài phương thức hay sức dụng
            arrLstKhongDinhKieu.Clear();//Xóa hết giá trị bên trong ArrayList
            



        }

        
    }
}
