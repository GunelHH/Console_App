using System;
namespace My_Console_Application.Models
{
    class Students
    {
        public string FullName;
        public string GroupNo;
        public bool Type;
     

        public Students(string fullname,string groupno)
        {
            FullName = fullname;
            GroupNo = groupno;
            Type = false;
           
        }
        public string GetFullName(string fullname)
        {
            string[]  charArr = fullname.Split(" ");
            foreach (string  item in charArr)
            {
                item.ToLower();
            }
            return charArr.ToString();
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

        //public override string ToString()
        //{
        //    return $"Fullname: {FullName} Group no:{ GroupNo}";
        //}




    }
}
