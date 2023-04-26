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
    public class AlternativesController
    {
        private Context _contex;
        public AlternativesController(Context context){
            _contex = context;
        }
        [HttpGet]
        public IEnumerable<Alternatives> get(){
            return _contex.alternatives.ToList();
        }
        [HttpPost]
        public Alternatives post(Alternatives alternatives){
            _contex.alternatives.Add(alternatives);
            _contex.SaveChanges();
            return alternatives;
        }
    }
}