using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab09
{
    [Serializable]
    class University
    {
        private string name;
        private List<Student> students;


        /*
        *public University() { }
        * xmle dönüştürmek için gerekli
        */
        public University(string name)
        {
            this.Name = name;
            Students = new List<Student>();
        }

        public string Name { get => name; set => name = value; }
        public List<Student> Students { get => students; set => students = value; }

        public void AddStudent(Student s)
        {
            Students.Add(s);
        }

        public Student SearchStudent(string name)
        {
           foreach(Student i in Students)
            {
                if(name==i.Name)
                {
                    return i;
                }
                
            }
           
            throw new StudentNotFound(name+ " İsimle öğrenci bulunamadı. ");
        }
     
        
        public Student SearchStudent(int no)
        {
            foreach(Student i in Students)
            {
                if(no==i.No)
                {
                    return i;
                }
            }
            

            throw new StudentNotFound(no+ " Numaralı öğrenci bulunamadı. ");
        }

       
    }
}
