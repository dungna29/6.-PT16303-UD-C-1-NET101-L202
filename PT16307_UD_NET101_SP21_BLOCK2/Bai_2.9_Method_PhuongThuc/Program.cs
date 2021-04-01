using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._9_Method_PhuongThuc
{
    class Program
    { 
        /*
       *  Bài 2.9 Phương thức - Method
       *  Định nghĩa: 1 tập các câu lệnh cùng nhau thực hiện 1 tác vụ nào đó.
       *  LỢI ÍCH: - Giúp quản lý code tốt hơn
       *           - Tái sử dụng
       *
       *  Công thức chung:
       *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
       *  {
       *          Body code
       *  }
         *
       * <Phạm vi truy cập> - Access Specifier:Public,Private,Protected, Default, Internal
       *
       * <Kiểu trả về> : có 2 kiểu trả về và không trả về
       *          - Kiểu không trả về: void
       *          - Kiểu trả về: là giá trị đơn(int,string,double....) hoặc tập giá trị(Array,List.....) hoặc đối tượng(class) và còn nhiều kiểu khác.
       *
       * <Tên phương thức>: Tên động từ viết thường + tên.
       * <Danh sách tham số>: Phương thức có thể có tham hoặc không tham số và lưu ý khi sử dụng tham số thì khi gọi phương thức thì phải truyền đúng vị trí của tham số và kiểu dữ liệu.
        

        PHƯƠNG THỨC KHÔNG ĐƯỢC TRÙNG TÊN NHƯNG ĐƯỢC PHÉP TRÙNG TÊN VÀ KHÁC THAM SỐ
       */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            #region Phần 1: Phương thức không trả về Void

            PhuongThucKhongTraVe pt = new PhuongThucKhongTraVe();
            /*
             * 1. Hướng dẫn sử dụng phương thức không trả về:
             *      - Cần biết tên phương thức và phương thức đó đang nằm trong class nào.
             *      - Khi gọi ra kết thúc phải ();
             */
            //pt.tinhTong;//Lỗi
            pt.tinhTong();


            /*
             * 2. Sử dụng phương thức không trả có tham số:
             *      - Bắt buộc truyền đúng thứ tự vị trí tham số và đúng kiểu dữ liệu
             *      - Bắt buộc phải truyền tham số nếu phương thức có
             *      - Nếu là nạp chồng phương thức thì truyền số lượng tham số sẽ gọi đúng tham số cần gọi
             */
            //pt.tinhTong(5); Truyền thiếu tham số
            pt.tinhTong(5,5);
            #endregion

            PhuongThucTraVe ptTraVe = new PhuongThucTraVe();
            //ptTraVe.tinhTong(); Nó là 1 giá trị không thể tự in
            Console.WriteLine(ptTraVe.tinhTong());
        }
    }
}
