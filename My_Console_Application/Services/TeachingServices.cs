using System;
using System.Collections.Generic;
using System.Linq;
using My_Console_Application.Enums;
using My_Console_Application.Interface;
using My_Console_Application.Models;

namespace My_Console_Application.Services
{
    class TeachingServices : ITeachingServices
    {
        private List<Group> _groups= new List<Group>();

        public List<Group> Groups => _groups;

        private List<Students> _student = new List<Students>();

        public List<Students> student => _student;

        public string CreateGroup(string  no, Categories category,bool isonline)
        {
            Console.WriteLine("Please entire Group No");
     
            
            if (no=="0" && no=="-")
            {
                Console.WriteLine("Please choose correct Group No");
                
            }
            foreach (char item in no)
            {
                if (!char.IsDigit(item))
                {
                    Console.WriteLine("Please entire the number");
                    
                }
            }
           
            Group group = new Group(no, category, isonline);

            Groups.Add(group);
            return group.No;
        }

        public void ListOfGroups()
        {
            if (Groups.Count==0)
            {
                Console.WriteLine("No yet Group");
            }
            foreach (Group group in Groups)
            {
                Console.WriteLine(group);
            }
        }

        public void EditGroups(string no,string newno)
        {
            Group existGroup = FindGroup(no);
            if (existGroup==null)
            {
                Console.WriteLine("Please choose correct Group no ");
                return;
            }
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim()==newno.Trim().ToLower())
                {
                    Console.WriteLine($"The Group no {newno} is already exist");
                    return;
                }
            }
            existGroup.No = newno;
            Console.WriteLine($"{no} group successfully changed to {newno} ");
        }

        public Group FindGroup(string no)
        {
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim()==no.Trim().ToLower())
                {
                    return group;
                }
            }
            return null;
        }

        public void ListofStudentsInGroup(string no)
        {
            Group group = FindGroup(no);
            if (group==null)
            {
                Console.WriteLine("Please choose valid Group no");
                return;
            }
            if (group.No!=no)
            {
                Console.WriteLine("There is no such Group");
                return;
            }
            foreach (Group student1 in Groups)
            {
                Console.WriteLine(student1.Students);
            }

        }

        public void ListOfAllStudents()
        {
            if (student.Count == 0)
            {
                Console.WriteLine("There is no student yet");
                return;
            }
            foreach (Students students in student)
            {
                Console.WriteLine(students);
            }
        }

        public void CreateStudent(string fullname,string groupno,bool type)
        {
            if (string.IsNullOrEmpty(fullname))
            {
                Console.WriteLine("Please enter correctly");
                return;
            }
            foreach (char item in fullname)
            {
                if (char.IsDigit(item))
                {
                    Console.WriteLine("Please enter correctly");
                    return;
                }
            }
            Students students = new Students(fullname, groupno);
            students.GetFullName(fullname);
            student.Add(students);

            Group group = FindGroup(groupno);
            if (group==null)
            {
                Console.WriteLine("Please enter correctly");
                return;
            }
           
            group = Groups.Find(x => x.No.Trim().ToUpper() == groupno.Trim().ToUpper());

            group.Students.Add(students);

            Console.WriteLine("Student successfully created ");

        }
    }
}
