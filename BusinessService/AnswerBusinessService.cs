using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.DataService;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.BusinessService
{
    public class AnswerBusinessService
    {
        private AnswerDataService _answerDataService;
        public AnswerBusinessService(AnswerDataService answerDataService){
            _answerDataService = answerDataService;
        }
        public IEnumerable<Answer> get(){
            return _answerDataService.get();
        }
        public Answer? get(long id){
            return _answerDataService.get(id);
        }
        public Answer? post(AnswerVM AnswerVM){
            if (AnswerVM.questionId == 0) return null;
            var Answer = generarAnswerVM(AnswerVM);
            var insertedAnswer = _answerDataService.post(Answer);
            return insertedAnswer;
        }
        public Answer? update(AnswerVM AnswerVM){
            if(AnswerVM.id == 0 || AnswerVM.questionId == 0) return null;
            var Answer = generarAnswerVM(AnswerVM);
            var upadtedAnswer = _answerDataService.update(Answer);
            return upadtedAnswer;
        }
        public string delete(long id){
            return _answerDataService.delete(id);
        }

        //-----------MODULOS
        public Answer generarAnswerVM(AnswerVM AnswerVM){
            var Answer = new Answer(){
                id = AnswerVM.id,
                answer = AnswerVM.answer,
                questionId = AnswerVM.questionId,
                question = null
            };
            return Answer;
        }
    }
}