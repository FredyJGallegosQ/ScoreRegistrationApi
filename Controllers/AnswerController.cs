using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegistroNotasApi.BusinessService;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnswerController: ControllerBase
    {
        private AnswerBusinessService _answerBusinessService;
        public AnswerController(AnswerBusinessService answerBusinessService){
            _answerBusinessService = answerBusinessService;
        }
        [HttpGet]
        public IEnumerable<Answer> get(){
            return _answerBusinessService.get();
        }
        [HttpGet("{id}")]
        public Answer? get(long id){
            return _answerBusinessService.get(id);
        }
        [HttpPost]
        public Answer? post(AnswerVM Answer){
            return _answerBusinessService.post(Answer);
        }
        [HttpPut]
        public Answer? update(AnswerVM Answer){
            return _answerBusinessService.update(Answer);
        }
        [HttpDelete("{id}")]
        public string delete(long id){
            return _answerBusinessService.delete(id);
        }
    }
}