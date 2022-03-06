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
                Console.WriteLine("6. Create Student\n");

                string strselection = Console.ReadLine();


                bool ResultSelection = int.TryParse(strselection, out selection);

                if (ResultSelection)
                {
                    switch (selection)
                    {
                        case 1:
                            MenuServices.CreateGroupMenu();
                            break;
                        case 3:
                            MenuServices.EditGroupsMenu();
                            break;
                        case 4:
                            MenuServices.ListofStudentsInGroupMenu();
                            break;

                           

                        default:
                            Console.WriteLine("Please choose valid no 😊");
                            break;
                    }
                }


            //    TeachingServices teaching = new TeachingServices();
            //tryagain:
            //    Console.WriteLine("Please choose no: ");



            //    teaching.CreateGroup( Enums.Categories.Programming);

            //    string choise = Console.ReadLine();

            //    switch (choise)
            //    {
            //        case "1":
            //            Console.WriteLine("No : ");
            //            string no = Console.ReadLine();
            //            bool online;
            //            int Limit;
            //            Console.WriteLine("Is online(y/n) : ");
            //            string isonline = Console.ReadLine();
            //        tryagain:
            //            if (isonline == "y")
            //            {
            //                online = true;
            //                Limit = 15;
            //            }
            //            else if (isonline == "n")
            //            {
            //                online = false;
            //                Limit = 10;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Duzgun deyer daxil edin !");
            //                goto tryagain;
            //            }
            //            Console.WriteLine("Limit : ");


            //            break;
            //        case "2":
            //        default:
            //            break;
            //    }





            //    string StrSelection = Console.ReadLine();
            //    bool Result = int.TryParse(StrSelection, out selection);

            //    if (Result)
            //    {
            //        switch (selection)
            //        {
            //            case 1:
            //                TeachingServices.CreateGroup();
            //            default:
            //                break;
            //        }
            //    }
            } while (true);
        //    //TeachingServices teaching = new TeachingServices();
        //    //teaching.CreateGroup(Enums.Categories.Design);
        }
    }
}
