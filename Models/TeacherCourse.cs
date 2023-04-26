using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class TeacherCourse
    {
        public long id{get; set;}
        public long teacherId{get; set;}
        public long courseId{get; set;}
    }
}