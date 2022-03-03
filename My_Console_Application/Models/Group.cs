using System;
using My_Console_Application.Enums;

namespace My_Console_Application.Models
{

    class Group
    {
        public string No;
        Categories Category;
        public bool isOnline;
        public int Limit;
        public Students[] Student;
        public static int count=1;
        
        public Group(string fullname,string groupno,Categories category)
        {
            switch (category)
            {  
                case Categories.Programming:
                    No = $"PM-{count}";
                    break;
                case Categories.Design:
                    No = $"DS-{count}";
                    break;
                case Categories.System_Administration:
                    No = $"SA-{count}";
                    break;
                default:
                    break;
            }
            count++;
            Category = category;
            isOnline = false;
        }
       
    }
}
