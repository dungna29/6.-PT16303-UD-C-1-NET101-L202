using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_MAU_NHAP_XUAT_OOPV1
{
    class ServiceSinhVien
    {
        List<SinhVien> _lstSinhViens;
        SinhVien _sv;

        SinhVien[] _arrSinhViens;
        public ServiceSinhVien()
        {
            _lstSinhViens = new List<SinhVien>();
        }

        //Bài 1: Tạo 2 đối tượng sử dụng dụng Contrcutor có tham số và không tham số
        public void bai1Tao2DoiTuongSuDungContructor()
        {
            //Cách 1: Contructor có tham số
            SinhVien sv1 = new SinhVien("Trang", "PH00055", 2000, 4.9);

            //Cách 2: Contructor không tham số
            SinhVien sv2 = new SinhVien();
            sv2.Ten = "Hoàng";
            sv2.Msv = "PH00066";
            sv2.Ns = 2001;
            sv2.DiemCsharp = 8.9;

            sv1.inRaManHinh();
            sv2.inRaManHinh();
        }

        //Bài 2: Tạo 1 đối tượng do người dùng nhập vào
        public void bai2Tao1DoiTuongDoNguoiDungNhap()
        {
            SinhVien sv1 = new SinhVien();
            Console.WriteLine("Mời bạn nhập tên: ");
            sv1.Ten = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập msv: ");
            sv1.Msv = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập năm sinh: ");
            sv1.Ns = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập điểm: ");
            sv1.DiemCsharp = Convert.ToDouble(Console.ReadLine());

            sv1.inRaManHinh();
        }

        //Bài 3: Tạo Array đối tượng SinhVien 
        public void bai3TaoArrayDoiTuong()
        {
            //_arrSinhViens đưa mảng sinh viên ra làm biến toàn cục
            int size;
            Console.WriteLine("Mời bạn nhập số lượng SV: ");
            size = Convert.ToInt32(Console.ReadLine());//Gán giá trị do người nhập vào
            _arrSinhViens = new SinhVien[size];//Khởi tạo kích thước mảng sinh viên do người dùng nhập vào

            for (int i = 0; i < _arrSinhViens.Length; i++)
            {
                _arrSinhViens[i] = new SinhVien();//Khởi tạo đối tượng trước khi gán giá trị trong mảng 
                Console.WriteLine("Mời bạn nhập tên: ");
                _arrSinhViens[i].Ten = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập msv: ");
                _arrSinhViens[i].Msv = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập năm sinh: ");
                _arrSinhViens[i].Ns = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập điểm: ");
                _arrSinhViens[i].DiemCsharp = Convert.ToDouble(Console.ReadLine());
            }
            // arrSinhViens[i] Đối tượng SinhVien tại index
        }

        public void inMangSinhVien()
        {
            foreach (var x in _arrSinhViens)
            {
                x.inRaManHinh();
            }
        }

        //Bài 4: Thêm SinhVien Sử dụng List
        public void themSinhVienList()
        {
            int size;
            Console.WriteLine("Mời bạn nhập số lượng SV: ");
            size = Convert.ToInt32(Console.ReadLine());//Gán giá trị do người nhập vào
            for (int i = 0; i < size; i++)
            {
                _sv = new SinhVien();//Muốn dùng phải khởi tạo
                Console.WriteLine("Mời bạn nhập tên: ");
                _sv.Ten = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập msv: ");
                _sv.Msv = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập năm sinh: ");
                _sv.Ns = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập điểm: ");
                _sv.DiemCsharp = Convert.ToDouble(Console.ReadLine());
                _lstSinhViens.Add(_sv);//Thêm 1 đối tượng sau mỗi vòng chạy vào List SinhVien
            }
        }
    }
}
