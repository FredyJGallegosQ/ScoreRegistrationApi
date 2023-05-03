using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegistroNotasApi.Models;
using RegistroNotasApi.BusinessService;

namespace RegistroNotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionController: ControllerBase
    {
        private QuestionBusinessService _questionBusinessService;
        public QuestionController(QuestionBusinessService questionBusinessService){
            _questionBusinessService = questionBusinessService;
        }
        [HttpGet]
        public IEnumerable<Question> get(){
            return _questionBusinessService.get();
        }
        [HttpGet("{id}")]
        public Question? get(long id){
            return _questionBusinessService.get(id);
        }
        [HttpPost]
        public Question? post(QuestionVM questionVM){
            return _questionBusinessService.post(questionVM);
        }
        [HttpPut]
        public Question? update(QuestionVM questionVM){
            return _questionBusinessService.update(questionVM);
        }
        [HttpDelete("{id}")]
        public string delete(long id){
            return _questionBusinessService.delete(id);
        }
    }
}