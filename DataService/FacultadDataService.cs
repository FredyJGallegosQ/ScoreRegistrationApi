using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.DataService
{
    public class FacultadDataService
    {
        private Context _context;
        public FacultadDataService(Context context){
            _context = context;
        }
        public IEnumerable<Facultad> get(){
            return _context.facultads.Include(f => f.pSs).ToList();
        }
        public Facultad? get(long id){
            var facultadDb = _context.facultads.Find(id);
            return facultadDb;
        }
        public Facultad post(Facultad facultad){
            _context.facultads.Add(facultad);
            _context.SaveChanges();
            return facultad;
        }
        public Facultad? update(Facultad facultad){
            var facultadDb = _context.facultads.Find(facultad.id);
            if(facultadDb == null) return null;
            facultadDb.name = facultad.name;
            _context.SaveChanges();
            return facultad;
        }
        public string delete(long id){
            var facultadDb = _context.facultads.Find(id);
            if(facultadDb == null) return "Registro no existe";
            _context.facultads.Remove(facultadDb);
            _context.SaveChanges();
            return "Registro " + id + " se eliminó satisfactoriamente";
        }
    }
}