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
        [HttpGet("{id}")]
        public Alternatives? get(long id){
            var alternativesDb = _contex.alternatives.Find(id);
            if(alternativesDb == null) return null;
            return alternativesDb;
        }
        [HttpPost]
        public Alternatives? post(Alternatives alternatives){
            _contex.alternatives.Add(alternatives);
            _contex.SaveChanges();
            return alternatives;
        }
        [HttpPut]
        public Alternatives? update(Alternatives alternatives){
            var alternativesDb = _contex.alternatives.Find(alternatives.id);
            if(alternativesDb == null) return null;
            alternativesDb.alternative1 = alternatives.alternative1;
            alternativesDb.alternative2 = alternatives.alternative2;
            alternativesDb.alternative3 = alternatives.alternative3;
            alternativesDb.alternative4 = alternatives.alternative4;
            alternativesDb.alternative5 = alternatives.alternative5;
            alternativesDb.answer = alternatives.answer;
            _contex.SaveChanges();
            return alternativesDb;
        }
        [HttpDelete("{id}")]
        public string delete(long id){
            var alternativesDb = _contex.alternatives.Find(id);
            if(alternativesDb == null) return "No existe registro";
            _contex.alternatives.Remove(alternativesDb);
            _contex.SaveChanges();
            return "Registro " + id + " se eliminó satisfactoriamente";
        }
    }
}