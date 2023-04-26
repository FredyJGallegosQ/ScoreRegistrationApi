using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class Registration
    {
        public long id{get; set;}
        public long semesterId{get; set;}
        public long studentId{get; set;}
        public long psId{get; set;}
        public long courseId{get; set;}
    }
}