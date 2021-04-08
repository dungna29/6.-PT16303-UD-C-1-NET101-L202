using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_MAU_CRUD_OOP_V2
{
    class Person
    {
        private string ten;
        private string sdt;
        private string email;

        public Person()
        {
            
        }

        public Person(string ten, string sdt, string email)
        {
            this.ten = ten;
            this.sdt = sdt;
            this.email = email;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
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

        public virtual void inRaManHinh()
        {

        }
    }
}
