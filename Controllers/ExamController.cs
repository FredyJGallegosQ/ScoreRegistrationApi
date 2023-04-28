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
    public class ExamController
    {
        private ExamBusinessService _examBusinessService;
        public ExamController(ExamBusinessService examBusinessService){
            _examBusinessService = examBusinessService;
        }
        [HttpGet]
        public IEnumerable<Exam> get(){
            return _examBusinessService.get();
        }
        [HttpGet("{id}")]
        public Exam? get(long id){
            return _examBusinessService.get(id);
        }
        [HttpPost]
        public Exam? post(ExamVM exam){
            return _examBusinessService.post(exam);
        }
        [HttpPut]
        public Exam? update(ExamVM exam){
            return _examBusinessService.update(exam);
        }
        [HttpDelete("{id}")]
        public string delete(long id){
            return _examBusinessService.delete(id);
        }
    }
}