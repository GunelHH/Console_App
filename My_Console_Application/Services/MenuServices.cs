﻿using System;
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

            tryagain:
           
            foreach (Categories category in System.Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)category}. {category}");
            }
            int num;
            string Strnum = Console.ReadLine();
            bool Resultnum = int.TryParse(Strnum, out num);
            if (Resultnum)
            {
                switch (num)
                {  
                    case (int)Categories.Programming:
                        string No=teachingServices.CreateGroup(Categories.Programming);
                        Console.WriteLine($"{No} Group successfully created");
                        break;
                    case (int)Categories.Design:
                        No=teachingServices.CreateGroup(Categories.Design);
                        Console.WriteLine($"{No} Group successfully created");
                        break;
                    case (int)Categories.System_Administration:
                        No=teachingServices.CreateGroup(Categories.System_Administration);
                        Console.WriteLine($"{No} Group successfully created");
                        break;
                    default:
                        Console.WriteLine("No such Category");
                        return;
                }
            }
            else
            {
                Console.WriteLine("Please choose correct no");
                goto tryagain;
            }
            Categories categories = new Categories();
            teachingServices.CreateGroup(categories);
            //teachingServices.CheckIsOnline();

        }

        public static void EditGroupsMenu()
        {
            Console.WriteLine("Please enter the Group no that you want to rename");

            string no = Console.ReadLine();

            Console.WriteLine("Please ehter the New no");

            string newno = Console.ReadLine();

            teachingServices.EditGroups(no,newno);
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

        }










       //public static CreateGroupMenu()
       // {

        //     Console.WriteLine("Please choose Category");
        //     foreach (Categories categories in Enum.GetValues(typeof(Categories)))
        //     {
        //         Console.WriteLine($"categ");
        //     }

        //     if (Resultisonline)
        //     {
        //         Group group;
        //         group.isOnline = true;
        //     }

        //     if (Resultisonline)
        //     {
        //         Console.WriteLine("Please choose Category");
        //         foreach (Categories cat in System.Enum.GetValues(typeof(Categories)))
        //         {
        //             Console.WriteLine($"{(int)cat}. {cat}");
        //         }
        //     }
        //     int category;
        //     string Strcategory = Console.ReadLine();
        //     bool Resulcategory = int.TryParse(Strcategory, out category);
        //     if (Resulcategory)
        //     {
        //         switch (category)
        //         {
        //             case (int)Categories.Programming:


        //             default:
        //                 break;
        //         }
        //     }

        //     TeachingServices teachingServices = new TeachingServices();
        //     teachingServices.CreateGroup();
        // }
    }
}
