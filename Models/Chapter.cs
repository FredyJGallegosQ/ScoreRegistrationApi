using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class Chapter
    {
        public long id{get; set;}
        public string name{get; set;}
        public long courseId{get; set;}
        [ForeignKey(nameof(courseId))]
        public Course? course{get; set;}
        public IEnumerable<Exam> exams{get; set;}

    }
    public class ChapterVM
    {
        public long id{get; set;}
        public string name{get; set;}
        public long courseId{get; set;}
    }
}