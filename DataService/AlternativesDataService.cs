using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.DataService
{
    public class AlternativesDataService
    {
        private Context _context;
        public AlternativesDataService(Context context){
            _context = context;
        }
        public IEnumerable<Alternatives> get(){
            return _context.alternatives.ToList();
        }
        public Alternatives? get(long id){
            var alternativesDb = _context.alternatives.Find(id);
            if(alternativesDb == null) return null;
            return alternativesDb;
        }
        public Alternatives? post(Alternatives alternatives){
            _context.alternatives.Add(alternatives);
            _context.SaveChanges();
            return alternatives;
        }
        public Alternatives? update(Alternatives alternatives){
            var alternativesDb = _context.alternatives.Find(alternatives.id);
            if(alternativesDb == null) return null;
            alternativesDb.alternative1 = alternatives.alternative1;
            alternativesDb.alternative2 = alternatives.alternative2;
            alternativesDb.alternative3 = alternatives.alternative3;
            alternativesDb.alternative4 = alternatives.alternative4;
            alternativesDb.alternative5 = alternatives.alternative5;
            alternativesDb.answer = alternatives.answer;
            _context.SaveChanges();
            return alternativesDb;
        }
        public string delete(long id){
            var alternativesDb = _context.alternatives.Find(id);
            if(alternativesDb == null) return "No existe registro";
            _context.alternatives.Remove(alternativesDb);
            _context.SaveChanges();
            return "Registro " + id + " se eliminó satisfactoriamente";
        }
    }
}