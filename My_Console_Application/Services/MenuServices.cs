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
            string Strnum;
            bool Resultnum;
            tryagain:

            foreach (Categories category in System.Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)category}. {category}");
            }
            Strnum = Console.ReadLine();
            Resultnum = int.TryParse(Strnum, out num);
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

            Console.WriteLine("Please enter the digits of New no");
            

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
            Console.WriteLine("Please enter the Group no");



        }

        public static void ListofGroupsMenu()
        {
            teachingServices.ListOfGroups();
        }

        public static void CreateStudentMenu()
        {
            teachingServices.CreateStudent();
        }
    }
}
