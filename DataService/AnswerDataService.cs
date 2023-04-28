using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.DataService
{
    public class AnswerDataService
    {
        private Context _context;
        public AnswerDataService(Context context){
            _context = context;
        }
       
        public IEnumerable<Answer> get(){
            return _context.answers.ToList();
        }
  
        public Answer? get(long id){
            var answerDb = _context.answers.Find(id);
            if(answerDb == null) return null;
            return answerDb;
        }

        public Answer post(Answer answer){
            _context.answers.Add(answer);
            _context.SaveChanges();
            return answer;
        }

        public Answer? update(Answer answer){
            var answerDb = _context.answers.Find(answer.id);
            if(answerDb == null) return null;
            answerDb.answer = answer.answer;
            answerDb.questionId = answer.questionId;
            _context.SaveChanges();
            return answerDb;
        }

        public string delete(long id){
            var answerDb = _context.answers.Find(id);
            if(answerDb == null) return "No existe registro";
            _context.answers.Remove(answerDb);
            _context.SaveChanges();
            return "Registro " + id + " se eliminó satisfactoriamente";
        }
    }
}