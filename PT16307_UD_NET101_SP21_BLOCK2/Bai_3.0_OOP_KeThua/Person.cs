using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._0_OOP_KeThua
{
    /*
     * 1. Đưa các thuộc tính chung lên lớp cha
     * 2. Lớp cha cũng như là 1 một lớp đối tượng bình thường
     */
    class Person
    {
        private string ten;
        private string ho;
        private string tendem;
        private string sdt;
        private string email;

        public Person()
        {
            
        }

        public Person(string ten, string ho, string tendem, string sdt, string email)
        {
            this.ten = ten;
            this.ho = ho;
            this.tendem = tendem;
            this.sdt = sdt;
            this.email = email;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Ho
        {
            get => ho;
            set => ho = value;
        }

        public string Tendem
        {
            get => tendem;
            set => tendem = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }


        //Khi sử dụng từ khóa virtual trên phương thức của lớp cha thì lớp con có thể ghi đè lại phương thức này đây gọi là overiding trong tính đa hình của OOP
        public virtual void inRaManHinh()
        {
            Console.WriteLine("Đây là text inRaManHinh() của Person");
        }
    }
}
