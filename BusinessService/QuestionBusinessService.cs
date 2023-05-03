using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.DataService;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.BusinessService
{
    public class QuestionBusinessService
    {
        private QuestionDataService _questionDataService;
        public QuestionBusinessService(QuestionDataService questionDataService){
            _questionDataService = questionDataService;
        }
        public IEnumerable<Question> get(){
            return _questionDataService.get();
        }
        public Question? get(long id){
            return _questionDataService.get(id);
        }
        public Question? post(QuestionVM questionVM){
            var question = generateQuestionVM(questionVM);
            _questionDataService.post(question);
            return question;
        }
        public Question? update(QuestionVM questionVM){
            var question = generateQuestionVM(questionVM);
            _questionDataService.update(question);
            return question;
        }
        public string delete(long id){
            return _questionDataService.delete(id);
        }
        //--------MODULOS
        public Question generateQuestionVM(QuestionVM questionVM){
            var question = new Question{
                id = questionVM.id,
                question = questionVM.question,
                examId = questionVM.examId
            };
            return question;
        }
    }
}