using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using My_Console_Application.Models;

namespace My_Console_Application.Interface
{
    interface IGroupNoable
    {
        public List<Students> Student = new List<Students>();

        public Group CreateGroup { get; set; }

        public string ListOfGroup { get; set; }

        public string ToCorrectGroup { get; set; }

        public string  ListofStudentsInGroup { get; set; }

        public string ListOfAllStudents { get; set; }

        public string CreateStudent { get; set; }
    }
}
