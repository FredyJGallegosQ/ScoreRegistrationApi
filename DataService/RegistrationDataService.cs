using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.DataService
{
    public class RegistrationDataService
    {
        private Context _context;
        public RegistrationDataService (Context context){
            _context = context;
        }
        public IEnumerable<Registration> get(){
            return _context.registrations.ToList();
        }
        public Registration? get(long id){
            var registrationDb = _context.registrations.Find(id);
            return registrationDb;
        }
        public Registration post(Registration registration){
            _context.registrations.Add(registration);
            _context.SaveChanges();
            return registration;
        }
        public Registration? update(Registration registration){
            var registrationDb = _context.registrations.Find(registration.id);
            if(registrationDb == null) return null;
            registrationDb.semesterId = registration.semesterId;
            registrationDb.studentId = registration.studentId;
            registrationDb.psId = registration.psId;
            _context.SaveChanges();
            return registrationDb;
        }
        public string delete(long id){
            var registrationDb = _context.registrations.Find(id);
            if(registrationDb == null) return "Registro no existe";
            _context.registrations.Remove(registrationDb);
            _context.SaveChanges();
            return "Registro " + id + " se eliminó satisfactoriamente";
        }
    }
}