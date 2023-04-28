using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public IEnumerable<Question> questions{get; set;}
        [ForeignKey(nameof(chapterId))]
        public Chapter? chapter{get; set;}
    }
    public class ExamVM
    {
        public long id{get; set;}
        public DateTime fecha{get; set;}
        public float score{get; set;}
        public long chapterId{get; set;}
    }
}