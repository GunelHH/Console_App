using System;
using System.Collections.Generic;
using My_Console_Application.Enums;

namespace My_Console_Application.Models
{

    class Group
    {
        public string No;
        Categories Category;
        public bool isOnline;
        public int Limit;
        public List<Student> Students;
        public static int count=1;


        public Group(Categories category,bool isonline)
        {
            Students = new List<Student>();
            switch (category)
            {
                case Categories.Programming:
                    No = $"PM{count}";
                    break;
                case Categories.Design:
                    No = $"DS{count}";
                    break;
                case Categories.System_Administration:
                    No = $"SA{count}";
                    break;
                default:
                    break;
            }
            count++;
            Category = category;
            isOnline = isonline;
        }
        public override string ToString()
        {
            string status = isOnline ? "Online" : "Offline";
            return $"No: {No} ,Category: {Category},Status: {status} ";
        }
        


    }
}
