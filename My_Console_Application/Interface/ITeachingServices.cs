using System;
using System.Collections.Generic;
using My_Console_Application.Enums;
using My_Console_Application.Models;

namespace My_Console_Application.Interface
{
   interface ITeachingServices
    {
        public List<Group> Groups { get; }

        public string CreateGroup(Categories category);

        public void ListOfGroups();

        public void EditGroups(string no, string newno);

        public void ListofStudentsInGroup(string no);

        public void ListOfAllStudents();

        public void CreateStudent();
    }
}
