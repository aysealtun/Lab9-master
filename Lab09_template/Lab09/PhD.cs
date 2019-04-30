using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab09
{
    [Serializable]
    class PhD : Student
    {


        /*
        *public PhD() { }
        * xmle dönüştürmek için gerekli
        */
        public PhD(string name, string surname, int no) : base(name, surname, no)
        {
            base.name = name;
            base.surname = surname;
            base.no = no;
        }
    }
}
