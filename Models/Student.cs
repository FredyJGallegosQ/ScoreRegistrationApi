using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class Student
    {
        public long id{get; set;}
        public string name{get; set;}
        public string lastname{get; set;}
        public int age{get; set;}
        public string email{get; set;}
        public IEnumerable<Registration>? registrations{get; set;}

    }
    public class StudentVM
    {
        public long id{get; set;}
        public string name{get; set;}
        public string lastname{get; set;}
        public int age{get; set;}
        public string email{get; set;}

    }
}