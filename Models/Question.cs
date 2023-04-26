using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class Question
    {
        public long id{get; set;}
        public string question{get; set;}
        public long examId{get; set;}
    }
}