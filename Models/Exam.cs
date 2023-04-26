using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class Exam
    {
        public long id{get; set;}
        public DateTime fecha{get; set;}
        public float score{get; set;}
        public long chapterId{get; set;}
    }
}