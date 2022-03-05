using System;
using System.Collections.Generic;
using My_Console_Application.Enums;

namespace My_Console_Application.Models
{

    class Group
    {
        public string No;
        Categories Category;
        public int Limit;
        public List<Students> Students;
        public bool isOnline;
        public static int count=1;
        
        public Group(string no,Categories category,bool isOnline)
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
