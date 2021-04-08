using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_MAU_CRUD_OOP_V2
{
    class Student:Person
    {
        private string msv;
        private double diemCsharp;

        public Student()
        {
            
        }

        public Student(string ten, string sdt, string email, string msv, double diemCsharp) : base(ten, sdt, email)
        {
            this.msv = msv;
            this.diemCsharp = diemCsharp;
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public double DiemCsharp
        {
            get => diemCsharp;
            set => diemCsharp = value;
        }

        public override void inRaManHinh()
        {
            Console.WriteLine("Tên: {0} Sđt: {1} Email: {2} Msv: {3} Điểm: {4}",Ten,Sdt,Email,msv,diemCsharp);
        }
    }
}
