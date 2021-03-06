using System;
using My_Console_Application.Enums;
using My_Console_Application.Models;

namespace My_Console_Application.Services
{
    static class MenuServices
    {
        public static TeachingServices teachingServices = new TeachingServices();


        public static void CreateGroupMenu()
        { 
            Console.WriteLine("Please choose Category");
            int num;
        tryagain:
            foreach (Categories category in System.Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)category}. {category}");
            }
            string Strnum = Console.ReadLine();
            bool Resultnum = int.TryParse(Strnum, out num);
            if (num==1 || num==2 || num==3)
            {
               
               
                switch (num)
                {  
                    case (int)Categories.Programming:
                        teachingServices.CreateGroup(Categories.Programming);
                        break;
                    case (int)Categories.Design:
                        teachingServices.CreateGroup(Categories.Design);;
                        break;
                    case (int)Categories.System_Administration:
                        teachingServices.CreateGroup(Categories.System_Administration);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please choose correct Category");
                goto tryagain;
            }

        }

        public static void EditGroupsMenu()
        {
            Console.WriteLine("Please enter the Group no that you want to rename");

            string no = Console.ReadLine();
            

            teachingServices.EditGroups(no);
        }

        public static void ListofStudentsInGroupMenu()
        {
            Console.WriteLine("Please enter the Group no:");
           
            string no = Console.ReadLine();

            teachingServices.ListofStudentsInGroup(no);
        }

        public static void ListOfAllStudentsMenu()
        {
            teachingServices.ListOfAllStudents();
        }

        public static void ListofGroupsMenu()
        {
            teachingServices.ListOfGroups();
        }

        public static void CreateStudentMenu()
        { bool type = false;
        tryagain:
            Console.WriteLine("Please enter: \n1. Warranty\n2.Not Warranty");
            int warranty;
            string Strwarranty = Console.ReadLine();
            bool Resultwarranty = int.TryParse(Strwarranty, out warranty);
            if (Resultwarranty)
            {
                switch (warranty)
                {
                    case 1:
                        type = true;
                        break;
                    case 2:
                        type = false;
                        break;
                    default:
                        Console.WriteLine("Please choose valid no");
                        goto tryagain;
                }
            }
            else
            {
                Console.WriteLine("Please enter the digit");
                goto tryagain;
            }
            teachingServices.CreateStudent(type);
        }
    }
}
