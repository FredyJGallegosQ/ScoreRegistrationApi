using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class CourseRegistration
    {
        public long id{get; set;}
        public long registrationId{get; set;}
        public long courseId{get; set;}
        [ForeignKey(nameof(courseId))]
        public Course? course{get; set;}
        [ForeignKey(nameof(registrationId))]
        public Registration? registration{get; set;}
    }
    public class CourseRegistrationVM
    {
        public long id{get; set;}
        public long registrationId{get; set;}
        public long courseId{get; set;}
    }
}