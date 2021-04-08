using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_MAU_CRUD_OOP_V2
{
    class ServiceStudent
    {
        private List<Student> _lstStudents = new List<Student>();
        private Student _student;
        private string _input;
        public ServiceStudent()
        {
            Student st1 = new Student("Hoàng", "0123", "hoang@", "PH01", 5.6);
            Student st2 = new Student("Tú", "0124", "Tu@", "PH02", 6);
            _lstStudents.Add(st1);
            _lstStudents.Add(st2);
        }

        public void addStudent()
        {
            Console.WriteLine("Mời bạn nhập số lượng: ");
            _input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt16(_input); i++)
            {
                _student = new Student();
                Console.WriteLine("Mời bạn nhập tên: ");
                _student.Ten = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập sdt: ");
                _student.Sdt = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập email: ");
                _student.Email = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập msv: ");
                _student.Msv = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập điểm C#1: ");
                _student.DiemCsharp = Convert.ToDouble(Console.ReadLine());
                _lstStudents.Add(_student);
            }
        }

        public void getListSV()
        {
            inDs(_lstStudents);
        }

        public void sortListSV()
        {
            inDs(_lstStudents.OrderBy(c => c.DiemCsharp).ToList());
        }

        public void timKiemSV()
        {
            Console.WriteLine("Mời bạn nhập mã cần tìm: ");
            _input = Console.ReadLine();
            int temp = getIndex(_input);
            if (temp == -1)
            {
                Console.WriteLine("Mã sinh viên không tồn tại");
                return;
            }
            _lstStudents[temp].inRaManHinh();
        }
        public void xoaSV()
        {
            Console.WriteLine("Mời bạn nhập mã cần tìm: ");
            _input = Console.ReadLine();
            int temp = getIndex(_input);
            if (temp == -1)
            {
                Console.WriteLine("Mã sinh viên không tồn tại");
                return;
            }
            _lstStudents.RemoveAt(temp);
            Console.WriteLine("Xóa thành công");
        }
        public void suaSV()
        {
            Console.WriteLine("Mời bạn nhập mã cần tìm: ");
            _input = Console.ReadLine();
            int temp = getIndex(_input);
            if (temp == -1)
            {
                Console.WriteLine("Mã sinh viên không tồn tại");
                return;
            }
            do
            {
                Console.WriteLine("Bạn muốn sửa thông tin gì");
                Console.WriteLine("1. Tên");
                Console.WriteLine("2. Số điện thoại");
                Console.WriteLine("3. Thoát");
                Console.WriteLine("Mời bạn chọn chức năng: ");
                _input = Console.ReadLine();
                switch (_input)
                {
                    case "1":
                        Console.WriteLine("Tên cũ của bạn: " + _lstStudents[temp].Ten);
                        Console.WriteLine("Bạn muốn sửa thành : ");
                        _lstStudents[temp].Ten = Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Sdt cũ của bạn: " + _lstStudents[temp].Sdt);
                        Console.WriteLine("Bạn muốn sửa thành : ");
                        _lstStudents[temp].Sdt = Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Ok tạm biệt nhé");
                        break;
                    default:
                        Console.WriteLine("Chức năng không tồn tại");
                        break;
                }
            } while (!(_input == "3"));
        }

        //Phương thức 1: Tái sử dụng khi in ra màn hình
        private void inDs(List<Student> lsStudents)
        {
            foreach (var x in lsStudents)
            {
                x.inRaManHinh();
            }
        }

        //Phương thức 2: Lấy index của đối tượng có trong danh sách
        private int getIndex(string msv)
        {
            for (int i = 0; i < _lstStudents.Count; i++)
            {
                if (_lstStudents[i].Msv == msv)
                {
                    return i;//Trả về vị trí của đối tượng cần tìm
                }
            }
            return -1;
        }
    }
}
