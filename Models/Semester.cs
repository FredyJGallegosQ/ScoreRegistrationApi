using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class Semester
    {
        public long id{get; set;}
        public string name{get; set;}
        public DateTime initDate{get; set;}
        public DateTime endDate{get; set;}
        public IEnumerable<Registration>? registrations{get; set;}
    }
    public class SemesterVM
    {
        public long id{get; set;}
        public string name{get; set;}
        public DateTime initDate{get; set;}
        public DateTime endDate{get; set;}
    }
}