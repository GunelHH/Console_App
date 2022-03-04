using System;
using System.Collections.Generic;
using My_Console_Application.Enums;
using My_Console_Application.Models;

namespace My_Console_Application.Interface
{
   interface ITeachingServices
    { 
        public List<Group> Groups { get; }

        public string CreateGroup(string no, int limit, Categories category);

        public void ListOfGroup();

        public void EditGroups();

        public void ListofStudentsInGroup();

        public void ListOfAllStudents();

        public void CreateStudent();
    }
}
