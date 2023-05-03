using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.DataService
{
    public class PSDataService
    {
        private Context _context;
        public PSDataService(Context context){
            _context = context;
        }
        public IEnumerable<PS> get(){
            return _context.ps.Include(p => p.facultad).Include(r => r.registrations).ToList();
        }
        public PS? get(long id){
            var pSDb = _context.ps.Find(id);
            return pSDb;
        }
        public PS? post(PS ps){
            _context.ps.Add(ps);
            _context.SaveChanges();
            return ps;
        }
        public PS? update(PS ps){
            var pSDb = _context.ps.Find(ps.id);
            if(pSDb == null) return null;
            pSDb.name = ps.name;
            pSDb.facultadId = ps.facultadId;
            _context.SaveChanges();
            return pSDb;
        }
        public string delete(long id){
            var pSDb = _context.ps.Find(id);
            if(pSDb == null) return "Registro no encontrado";
            _context.ps.Remove(pSDb);
            _context.SaveChanges();
            return "Registro " + id + " se eliminó satisfactoriamente";
        }
    }
}