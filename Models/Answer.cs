using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class Answer
    {
        public long id{get; set;}
        public long questionId{get; set;}
        public string answer{get; set;}
        [ForeignKey(nameof(questionId))]
        public Question? question{get; set;}
    }
    public class AnswerVM
    {
        public long id{get; set;}
        public long questionId{get; set;}
        public string answer{get; set;}
    }
}