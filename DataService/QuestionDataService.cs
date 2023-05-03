using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.DataService
{
    public class QuestionDataService
    {
        private Context _context;
        public QuestionDataService(Context context){
            _context= context;
        }
        public IEnumerable<Question> get(){
            return _context.questions.ToList();
        }
        public Question? get(long id){
            var questionDb = _context.questions.Find(id);
            return questionDb;
        }
        public Question? post(Question question){
            if(_context.questions.Find(question.id) != null) return null;
            _context.questions.Add(question);
            _context.SaveChanges();
            return question;
        }
        public Question? update(Question question){
            var questionDb = _context.questions.Find(question.id);
            if(questionDb == null) return null;
            questionDb.question = question.question;
            questionDb.examId = question.examId;
            _context.SaveChanges();
            return question;
        }
        public string delete(long id){
            var questionDb = _context.questions.Find(id);
            if(questionDb == null) return "Resgistro no existe";
            _context.questions.Remove(questionDb);
            _context.SaveChanges();
            return "Registro " + id + " se eliminó satisfactoriamente";
        }
    }
}