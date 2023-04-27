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
    public class AnswerController: ControllerBase
    {
        private Context _context;
        public AnswerController(Context context){
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Answer> get(){
            return _context.answers.ToList();
        }
        [HttpGet("{id}")]
        public Answer? get(long id){
            var answerDb = _context.answers.Find(id);
            if(answerDb == null) return null;
            return answerDb;
        }
        [HttpPost]
        public Answer post(Answer answer){
            _context.answers.Add(answer);
            _context.SaveChanges();
            return answer;
        }
        [HttpPut]
        public Answer? update(Answer answer){
            var answerDb = _context.answers.Find(answer.id);
            if(answerDb == null) return null;
            answerDb.answer = answer.answer;
            answerDb.questionId = answer.questionId;
            _context.SaveChanges();
            return answerDb;
        }
        [HttpDelete("{id}")]
        public string delete(long id){
            var answerDb = _context.answers.Find(id);
            if(answerDb == null) return "No existe registro";
            _context.answers.Remove(answerDb);
            _context.SaveChanges();
            return "Registro " + id + " se eliminó satisfactoriamente";
        }
    }
}