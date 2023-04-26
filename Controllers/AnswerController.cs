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
        [HttpPost]
        public Answer post(Answer answer){
            _context.answers.Add(answer);
            _context.SaveChanges();
            return answer;
        }
    }
}