using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class Course
    {
        public long id{get; set;}
        public string name{get; set;}
        public IEnumerable<Chapter>? chapters{get; set;}
        public IEnumerable<CourseRegistration>? courseRegistrations{get; set;}
        public IEnumerable<TeacherCourse>? teacherCourses{get; set;}
    }
    public class CourseVM
    {
        public long id{get; set;}
        public string name{get; set;}
        
    }
}