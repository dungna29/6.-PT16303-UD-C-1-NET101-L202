using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._3_KeThua
{
    class ClassChau:ClassCon
    {
        private string thuoctinhChau1;

        public ClassChau()
        {
            
        }

        public ClassChau(string thuocTinhCha1, string thuocTinhCha2, string thuocTinhCha3, string thuocTinhCon1, string thuocTinhCon2, string thuoctinhChau1) : base(thuocTinhCha1, thuocTinhCha2, thuocTinhCha3, thuocTinhCon1, thuocTinhCon2)
        {
            this.thuoctinhChau1 = thuoctinhChau1;
        }

        public string ThuoctinhChau1
        {
            get => thuoctinhChau1;
            set => thuoctinhChau1 = value;
        }

        public override void methodCha1()
        {
            base.methodCha1();
        }

        public override void methodCha2()
        {
            base.methodCha2();
        }
    }
}
