using System;
using System.Collections.Generic;
using System.Text;
using My_Console_Application.Enums;
using My_Console_Application.Interface;
using My_Console_Application.Models;

namespace My_Console_Application.Services
{
    class TeachingServices : ITeachingServices
    {
       
        private List<Group> _groups = new List<Group>();

        public List<Group> Groups => _groups;

        public Group FindGroup(string no)

        {
            foreach (Group group in _groups)
            {

                if (group.No.ToLower().Trim() == no.Trim().ToLower())
                {
                    return group;
                }
            }
            return null;
        }

        public string FindNewGroupNo(Group group)
        {
            StringBuilder str = new StringBuilder();
            str.Append(group.No[0]);
            str.Append(group.No[1]);
            return str.ToString();
        }

        public void EditGroups(string no)
        {
            Group group1 = FindGroup(no);
            if (group1 == null)
            {
                Console.WriteLine("Please choose correct Group no ");
                return;
            }
        tryagain:
            string newno = Console.ReadLine();
            if (string.IsNullOrEmpty(newno))
            {
                Console.WriteLine("Please choose correct value");
                goto tryagain;
            }
            foreach (char item in newno)
            {
                if (!char.IsDigit(item))
                {
                    Console.WriteLine("Please choose digit");
                    goto tryagain;
                }
            }
            string newletter = FindNewGroupNo(group1);
            newletter += newno;
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim() == newletter.ToLower().Trim())
                {
                    Console.WriteLine($"The Group no {newletter} is already exist");
                    return;
                }
            }

            group1.No = newno;
            Console.WriteLine($"{no} group successfully changed to {newletter} ");
        }

        public void ListOfAllStudents(string no)
        {
            Group group = FindGroup(no);
            if (group == null)
            {
                Console.WriteLine("Please choose correct no");
                return;
            }
            Console.WriteLine(group.Students);
        }

        public void ListofStudentsInGroup(string no)
        {
            Group group = FindGroup(no);
            if (group == null)
            {
                Console.WriteLine("Please enter correct no");
                return;
            }
            if (group.No != no)
            {
                Console.WriteLine("There is no such group");
            }
            Console.WriteLine(group.Students);
        }

        public void ListOfGroups()
        {
            if (_groups.Count == 0)
            {
                Console.WriteLine("No yet Group");
                return;
            }
            foreach (Group group in _groups)
            {
                Console.WriteLine(group);
            }
        }

        public void CreateGroup(Categories category)
        {
            Console.WriteLine("Please choose type of education\n1.Online\n2.Offline");
            bool result = false;
            int num;
            string numStr;
            bool Resultnum;
        tryagain:
            numStr = Console.ReadLine();
            Resultnum = int.TryParse(numStr, out num);
            if (num == 1 || num == 2)
            {
                switch (num)
                {
                    case 1:
                        result = true;
                        break;
                    case 2:
                        result = false;
                        break;

                }
            }
            else
            {
                Console.WriteLine("Please choose correct value");
                goto tryagain;
            }



            Group group = new Group(category, result);
            _groups.Add(group);
            Console.WriteLine(group.No + "-Group created");

        }

        public void CreateStudent()
        {
            Student student = new Student(GetFullName());
            //Console.WriteLine("Student successfully created");
            //Group group = null;
            //if (group == null)
            //{
            //    Console.WriteLine("There is no student yet");
            //    return;
            //}
            //group.Students.Add(student);
            //if (_groups.Count == 0)
            //{
            //    Console.WriteLine("There is no Group yet ");
            //    return;
            //}
            //if (group.No.ToLower().Trim() != groupno.Trim().ToLower())
            //{
            //    Console.WriteLine("There is no such Group ");
            //    return;
            //}


        }

        public string GetFullName()
        {
            Console.WriteLine("Please enter Full Name");
        tryagain:
            string fullname = Console.ReadLine();
            if (string.IsNullOrEmpty(fullname))
            {
                Console.WriteLine("Please enter correctly");
                goto tryagain;
            }
            if (!fullname.Trim().Contains(' '))
            {
                Console.WriteLine("Please enter correctly");
                goto tryagain;
            }
            fullname = fullname.Trim();
            string[] arr = fullname.Split(' ');
            if (arr.Length != 2)
            {
                Console.WriteLine("Please enter correctly");
                goto tryagain;
            }
            StringBuilder strbuild = new StringBuilder();
            StringBuilder strbuild1 = new StringBuilder();
            string str = arr[0];
            strbuild.Append(char.ToUpper(str[0]));
            string str1 = arr[1];
            strbuild1.Append(char.ToUpper(str1[0]));

            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsLetter(str[i]))
                {
                    Console.WriteLine("Please enter correctly");
                    goto tryagain;
                }
                strbuild.Append(char.ToLower(str[i]));
            }
            for (int i = 1; i < str1.Length; i++)
            {

                if (!char.IsLetter(str1[i]))
                {
                    Console.WriteLine("Please enter correctly");
                    goto tryagain;
                }
                strbuild1.Append(char.ToLower(str1[i]));
            }
            arr[0] = strbuild.ToString();
            arr[1] = strbuild1.ToString();
            fullname = String.Join(" ",arr);
            return fullname;
        }

    }     
}