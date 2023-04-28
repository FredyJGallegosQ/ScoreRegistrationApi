using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.DataService
{
    public class CourseRegistrationDataService
    {
        private Context _context;
        public CourseRegistrationDataService(Context context){
            _context = context;
        }
        public IEnumerable<CourseRegistration> get(){
            return _context.courseRegistrations.ToList();
        }
        public CourseRegistration? get(long id){
            var CourseRegistrationDb = _context.courseRegistrations.Find(id);
            return CourseRegistrationDb;
        }
        public CourseRegistration post(CourseRegistration CourseRegistration){
            _context.courseRegistrations.Add(CourseRegistration);
            _context.SaveChanges();
            return CourseRegistration;
        }
        public CourseRegistration? update(CourseRegistration CourseRegistration){
            var CourseRegistrationDb = _context.courseRegistrations.Find(CourseRegistration.id);
            if(CourseRegistrationDb == null) return null;
            CourseRegistrationDb.registrationId = CourseRegistration.registrationId;
            CourseRegistrationDb.courseId = CourseRegistration.courseId;
            _context.SaveChanges();
            return CourseRegistration;
        }
        public string delete(long id){
            var CourseRegistrationDb = _context.courseRegistrations.Find(id);
            if(CourseRegistrationDb == null) return "Registro no existe";
            _context.courseRegistrations.Remove(CourseRegistrationDb);
            _context.SaveChanges();
            return "Registro " + id + " se eliminó satisfactoriamente";
        }
    }
}