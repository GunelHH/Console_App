using System;
using System.Collections.Generic;
using My_Console_Application.Enums;
using My_Console_Application.Interface;
using My_Console_Application.Models;

namespace My_Console_Application.Services
{
    class TeachingServices : ITeachingServices
    {

        //public void ListofStudentsInGroup(string no)
        //{
        //    Group group = FindGroup(no);
        //    if (group == null)
        //    {
        //        Console.WriteLine("Please choose valid Group no");
        //        return;
        //    }
        //    if (group.No != no)
        //    {
        //        Console.WriteLine("There is no such Group");
        //        return;
        //    }
        //    foreach (Group student1 in Groups)
        //    {
        //        Console.WriteLine(student1.Students);
        //    }

        //}

        //public void ListOfAllStudents(Group group)
        //{
        //    if (group.Students.Count == 0)
        //    {
        //        Console.WriteLine("There is no student yet");
        //        return;
        //    }
        //    foreach (Student stu in group.Students)
        //    {
        //        Console.WriteLine(stu);
        //    }
        //}

        //public void CreateStudent(string fullname, string groupno, bool type, Group group)
        //{
        //    if (string.IsNullOrEmpty(fullname))
        //    {
        //        Console.WriteLine("Please enter correctly");
        //        return;
        //    }
        //    foreach (char item in fullname)
        //    {
        //        if (char.IsDigit(item))
        //        {
        //            Console.WriteLine("Please enter correctly");
        //            return;
        //        }
        //    }

        //    Student students = new Student(fullname, groupno);
        //    students.GetFullName(fullname);
        //    //group.Students.Add(students);

        //    Group group1 = FindGroup(groupno);
        //    if (group1 == null)
        //    {
        //        Console.WriteLine("Please enter correctly");
        //        return;
        //    }
        //    if (group1.No.Trim().ToLower() == groupno.ToLower().Trim())
        //    {

        //    }

        //    //group = Groups.Find(x => x.No.Trim().ToUpper() == groupno.Trim().ToUpper());

        //    group.Students.Add(students);
        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine("Student successfully created ");

        //}

        private List<Group> _groups = new List<Group>();

        public List<Group> Groups => _groups;

        public bool CheckIsOnline()
        {
            bool result = false;
            Console.WriteLine("Please choose type of education\n1.Online\n2.Offline");
            int num;
            string numStr = Console.ReadLine();
            bool strnum = int.TryParse(numStr, out num);
            if (strnum)
            {
                switch (num)
                {
                    case 1:
                        result = true;
                        break;
                    case 2:
                        result = false;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please choose correct no");
            }
            return result;
        } 

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

        public void EditGroups(string no,string newno)
        {
            Group group1 = FindGroup(no);
            if (group1 == null)
            {
                Console.WriteLine("Please choose correct Group no ");
                return;

            }
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim() == newno.Trim().ToLower())
                {
                    Console.WriteLine($"The Group no {newno} is already exist");
                    return;
                }
            }
            group1.No = newno;
            Console.WriteLine($"{no} group successfully changed to {newno} ");
        }

        public void ListOfAllStudents(string no)
        {
            Group group = FindGroup(no);
            if (group==null)
            {
                Console.WriteLine("Please choose correct no");
                return;
            }
            Console.WriteLine(group.Students);
        }
        public void ListofStudentsInGroup(string no)
        {
            Group group = FindGroup(no);
            if (group==null)
            {
                Console.WriteLine("Please enter correct no");
                return;
            }
            if (group.No!=no)
            {
                Console.WriteLine("There is no such group");
            }
            Console.WriteLine(group.Students);
        }

        public void ListOfGroups()
        {
            if (_groups.Count==0)
            {
                Console.WriteLine("No yet Group");
                return;
            }
            foreach (Group group in _groups)
            {
                Console.WriteLine(group);
            }
        }

        public string CreateGroup(Categories category)
        {
            Group group = new Group(category);
            _groups.Add(group);
            return group.No;

        }

        public void CreateStudent(string fullname,string groupno,bool isonline)
        {
            if (string.IsNullOrEmpty(fullname))
            {
                Console.WriteLine("Please enter correctly");
                return;
            }
            Student student = new Student(fullname,groupno);
            student.GetFullName(fullname);
            Group group = null;
            if (group==null)
            {
                Console.WriteLine("There is no student yet");
                return;
            }
            group.Students.Add(student);
            if (_groups.Count==0)
            {
                Console.WriteLine("There is no Group yet ");
                return;
            }
            if (group.No.ToLower().Trim()!=groupno.Trim().ToLower())
            {
                Console.WriteLine("There is no such Group ");
                return;
            }
            if (group.No.ToLower().Trim() == groupno.Trim().ToLower())
            {
                group.Students.Add();
            }

        }
    }
}
