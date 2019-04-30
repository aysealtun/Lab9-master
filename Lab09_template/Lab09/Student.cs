using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab09
{

    [Serializable]
    abstract class Student
    {
        //Sadece get methodları olacak.
        protected string name;
        protected string surname;
        protected int no;

        public string Name { get => name; }
        public string Surname { get => surname; }
        public int No { get => no; }

        /*
     *public Student() { }
     * xmle dönüştürmek için gerekli
     */
        public Student(string name, string surname, int no)
        {

        }


        public override string ToString()
        {
            return "Ad:" + name + " Soyad: " + surname + " No: " + no;
        }

    }
}
