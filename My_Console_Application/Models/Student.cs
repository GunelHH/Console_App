using System;
using System.Text;

namespace My_Console_Application.Models
{
    class Student
    {
        public string Fullname;
        public string GroupNo;
        public bool Type;
       
     

        public Student(string fullname,bool type,string gruopno)
        {
            Fullname = fullname;
            Type = type;
            GroupNo = gruopno;
           
        }
        public override string ToString()
        {
            string status = Type ? "warranty" : "not warranty";
            return $"Fullname: {Fullname} Group no:{ GroupNo} Status:{status}";
        }

    }
}
