using System;
using My_Console_Application.Services;
using My_Console_Application.Models;

namespace My_Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==>  Course Management Application  <==");
            Console.WriteLine("\nPlease choose Transaction no:");
            int selection;
            do
            {
                
                Console.WriteLine("\n1. Create Group");
                Console.WriteLine("2. List of Groups");
                Console.WriteLine("3. Edit Groups");
                Console.WriteLine("4. List of Students in Group");
                Console.WriteLine("5. List of All Students");
                Console.WriteLine("6. Create Student");
                Console.WriteLine("0. Exit\n");

                string strselection = Console.ReadLine();


                bool ResultSelection = int.TryParse(strselection, out selection);

                if (ResultSelection)
                {
                    switch (selection)
                    {
                        case 1:
                            MenuServices.CreateGroupMenu();
                            break;
                        case 2:
                            MenuServices.ListofGroupsMenu();
                            break;
                        case 3:
                            MenuServices.EditGroupsMenu();
                            break;
                        case 4:
                            MenuServices.ListofStudentsInGroupMenu();
                            break;
                        case 5:
                            break;
                        case 6:
                            MenuServices.CreateStudentMenu();
                            break;

                           

                        default:
                            Console.WriteLine("Please choose valid no 😊");
                            break;
                    }
                }

            } while (selection!=0);
        }
    }
}
