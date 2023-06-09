using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class Teacher
    {
        public long id{get; set;}
        public string name{get; set;}
        public string lastname{get; set;}
        public int age{get; set;}
        public string email{get; set;}
        public IEnumerable<TeacherCourse>? teacherCourses{get; set;}
    }
    public class TeacherVM
    {
        public long id{get; set;}
        public string name{get; set;}
        public string lastname{get; set;}
        public int age{get; set;}
        public string email{get; set;}
    }
}