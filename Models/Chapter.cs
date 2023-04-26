using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class Chapter
    {
        public long id{get; set;}
        public string name{get; set;}
        public long courseId{get; set;}
    }
}