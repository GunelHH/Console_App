using System;
using System.Collections.Generic;
using My_Console_Application.Enums;
using My_Console_Application.Models;

namespace My_Console_Application.Interface
{
   interface ITeachingServices
    {
        public List<Group> Groups { get; }

        public List<Student> students { get; }
        

        public void CreateGroup(Categories category);

        public void ListOfGroups();

        public void EditGroups(string no);

        public void ListofStudentsInGroup(string no);

        public void ListOfAllStudents();

        public void CreateStudent();
    }
}