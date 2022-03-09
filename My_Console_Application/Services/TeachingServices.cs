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

        private List<Student> _students = new List<Student>();

        public List<Student> students => _students;

        public Group FindGroup(string no)

        {
            foreach (Group group in Groups)
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
                    goto tryagain;
                }
            }

            group1.No = newno;
            Console.WriteLine($"{no} group successfully changed to {newletter} ");
        }

        public void ListOfAllStudents()
        {
            foreach (var student in _students)
            {
                Console.WriteLine(student);
               
            }

        }

        public void ListofStudentsInGroup(string no)
        {
            Group group = FindGroup(no);
            if (string.IsNullOrWhiteSpace(no))
            {
                Console.WriteLine("Please enter correctly");
                return;
            }
            if (group.Students.Count == 0)
            {
                Console.WriteLine("There is no student yet");
                return;
            }
            string type = "";
            if(group.isOnline == true)
            {
                type = "online";
            }
            else
            {
                type = "offline";
            }
           
            if (group == null)
            {
                Console.WriteLine("Please enter correct no");
                return;
            }
            if (group.No.ToLower().Trim()!=no.ToLower().Trim())
            {
                Console.WriteLine("There is no such group");
                return;
            }
            foreach (Student student in group.Students)
            {
                Console.WriteLine($"{student} ,Type :{type}");
            }
        }

        public void ListOfGroups()
        {
            if (Groups.Count == 0)
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
            Group group = new Group(category, CheckIsOnline());
            if (group.isOnline)
            {
                group.Limit = 15;
            }
            else
            {
                group.Limit = 10;
            }
            Groups.Add(group);
            Console.WriteLine(group.No + "-Group created");
        }

        public void CreateStudent(bool type)
        {
            Console.WriteLine("Please choose Group no");
            string groupno = Console.ReadLine();
            
            Student student = new Student(GetFullName(), type, groupno);
            Group group = Groups.Find(x => x.No.Trim().ToUpper() == groupno.Trim().ToUpper());
            if(group is null)
            {
                Console.WriteLine("Group not found");
                return;
            }
            if (group.Students.Count<group.Limit)
            {
                group.Students.Add(student);
                students.Add(student);
                Console.WriteLine("Student successfully created");
            }
            else
            {
                Console.WriteLine("Group is Full");
                return;
            }
            
        }
        public bool CheckIsOnline()
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
            return result;
        }

        public bool CheckWarranty()
        {
            Console.WriteLine("Please enter entrance score");
            bool res;
            int warranty;
            string Strwarranty = Console.ReadLine();
            bool Resultwarranty = int.TryParse(Strwarranty, out warranty);

            if (warranty >= 50 && warranty <= 100)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
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
            fullname = String.Join(' ',arr);
            return fullname;
        }

    }     
}