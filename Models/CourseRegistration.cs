using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class CourseRegistration
    {
        public long id{get; set;}
        public long registrationId{get; set;}
        public long courseId{get; set;}
    }
}