using System;
namespace My_Console_Application.Models
{
    class Student
    {
        public string Fullname;
        public string GroupNo;
        public bool Type;
       
     

        public Student(string fullname,string groupno)
        {
            Fullname = fullname;
            GroupNo = groupno;
            Type = false;
           
        }
        public void GetFullName(string fullname)
        {
            string[] arr = fullname.Split(" ");
            if (arr.Length==2)
            {
                for (int i = 0; i < fullname.Length; i++)
                {
                    if (char.IsUpper(fullname[0]))
                    {
                        char.IsLower(fullname[i]);
                        char.IsDigit(fullname[i]);
                        
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid one");
                    }
                }
            }
        }
        //public void GetExam(bool type)
        //{
        //    if (Exampoint>=50)
        //    {
        //        Type = true;
        //    }
        //    else
        //    {
        //        Type = false;
        //    }
        //}

        public override string ToString()
        {
            return $"Fullname: {Fullname} Group no:{ GroupNo}";
        }

    }
}
