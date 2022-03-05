using System;
using System.Collections.Generic;
using My_Console_Application.Enums;
using My_Console_Application.Models;

namespace My_Console_Application.Interface
{
   interface ITeachingServices
    { 
        public List<Group> Groups { get; }

        public List<Students> student { get; }

        public string CreateGroup(string no, Categories category,bool isonline);

        public void ListOfGroups();

        public void EditGroups(string no, string newno);

        public void ListofStudentsInGroup(string no);

        public void ListOfAllStudents();

        public void CreateStudent(string fullname, string groupno, bool type);
    }
}
