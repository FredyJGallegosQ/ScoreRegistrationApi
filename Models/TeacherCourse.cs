using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class TeacherCourse
    {
        public long id{get; set;}
        public long teacherId{get; set;}
        public long courseId{get; set;}
        [ForeignKey(nameof(teacherId))]
        public Teacher? teacher{get; set;}
        [ForeignKey(nameof(courseId))]
        public Course? course{get; set;}
    }
}