using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._0_OOP_KeThua
{
    /*
     * 1. Lớp con muốn kế thừa lớp cha sử dấu : <Tên lớp cha>
     * 2. C# và JAVA là ngôn ngữ đơn kế thừa. 1 Con chỉ có 1 cha.
     * 3. Khi lớp con kế thừa lớp cha thì sẽ thừa kế các thuộc tính và phương thức do cha chỉ định.
     */
    class SinhVien:Person
    {
        private string msv;
        private double diemJava;
        private double diemCsharp;

        public SinhVien()
        {
            
        }

        public SinhVien(string ten, string ho, string tendem, string sdt, string email, string msv1, double diemJava, double diemCsharp) : base(ten, ho, tendem, sdt, email)
        {
            msv = msv1;
            this.diemJava = diemJava;
            this.diemCsharp = diemCsharp;
            //Từ khóa this dùng để tham chiếu đến thuộc tính và phương thức của lớp hiện tại
            //Từ khóa base dùng để tham chiếu đến thuộc tính và phương thức của lớp cha
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public double DiemJava
        {
            get => diemJava;
            set => diemJava = value;
        }

        public double DiemCsharp
        {
            get => diemCsharp;
            set => diemCsharp = value;
        }
        //Sử dụng từ khóa override để ghi đè lên phương thức của lớp cha.
        //Khi kế thừa phải đúng kiểu dữ liệu kiểu phương thức và giống tham số. Bên trong body code có thể code lại theo luồng nghiệp vụ khác.
        public override void inRaManHinh()
        {
           // base.inRaManHinh();
           Console.WriteLine("Đây là text in ra từ phương thức inRaManHinh() của SinhVien ");
        }
    }
}
