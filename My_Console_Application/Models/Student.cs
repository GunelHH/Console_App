using System;
using System.Text;

namespace My_Console_Application.Models
{
    class Student
    {
        public string Fullname;
        public string GroupNo;
        public bool Type;
       
     

        public Student(string fullname)
        {
            Fullname = fullname;
            //GroupNo = groupno;
            Type = false;
           
        }
        public override string ToString()
        {
            return $"Fullname: {Fullname} Group no:{ GroupNo}";
        }

    }
}
