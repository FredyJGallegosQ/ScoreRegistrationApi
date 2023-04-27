using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionController: ControllerBase
    {
        private Context _context;
        public QuestionController(Context context){
            _context= context;
        }
        [HttpGet]
        public IEnumerable<Question> get(){
            return _context.questions.ToList();
        }
        [HttpGet("{id}")]
        public Question? get(long id){
            var questionDb = _context.questions.Find(id);
            return questionDb;
        }
        [HttpPost]
        public Question? post(Question question){
            if(_context.questions.Find(question.id) != null) return null;
            _context.questions.Add(question);
            _context.SaveChanges();
            return question;
        }
        [HttpPut]
        public Question? update(Question question){
            var questionDb = _context.questions.Find(question.id);
            if(questionDb == null) return null;
            questionDb.question = question.question;
            questionDb.examId = question.examId;
            _context.SaveChanges();
            return question;
        }
        [HttpDelete("{id}")]
        public string delete(long id){
            var questionDb = _context.questions.Find(id);
            if(questionDb == null) return "Resgistro no existe";
            _context.questions.Remove(questionDb);
            _context.SaveChanges();
            return "Registro " + id + " se eliminó satisfactoriamente";
        }
    }
}