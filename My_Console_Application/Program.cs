using System;
using My_Console_Application.Services;

namespace My_Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==>Course Management Application<==");
            int selection;
            //do
            //{
                Console.WriteLine("\n1. Create Group");
                Console.WriteLine("2. List of Groups");
                Console.WriteLine("3. Edit Groups");
                Console.WriteLine("4. List of Students in Group");
                Console.WriteLine("5. List of All Students");
                Console.WriteLine("6. Create Student");

            TeachingServices teaching = new TeachingServices();
            Console.WriteLine(teaching.CreateGroup("0", 15, Enums.Categories.Programming));
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
            //} while (true);
        }
    }
}
