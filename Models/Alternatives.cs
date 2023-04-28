using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class Alternatives
    {
        public long id{get; set;}
        public string alternative1{get; set;}
        public string alternative2{get; set;}
        public string alternative3{get; set;}
        public string alternative4{get; set;}
        public string alternative5{get; set;}
        public string answer{get; set;}
        public long questionId{get; set;}
        [ForeignKey(nameof(questionId))]
        public Question? question{get; set;}

    }
    public class AlternativesVM{
        public string alternative1{get; set;}
        public string alternative2{get; set;}
        public string alternative3{get; set;}
        public string alternative4{get; set;}
        public string alternative5{get; set;}
        public string answer{get; set;}
        public long questionId{get; set;}
    }
}
