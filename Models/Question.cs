using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class Question
    {
        public long id{get; set;}
        public string question{get; set;}
        public long examId{get; set;}
        public IEnumerable<Alternatives>? alternatives{get; set;}
        public IEnumerable<Answer>? answers{get; set;}
        [ForeignKey(nameof(examId))]
        public Exam? exam{get; set;}

    }
    public class QuestionVM{
        public long id{get; set;}
        public string question{get; set;}
        public long examId{get; set;}
    }
}