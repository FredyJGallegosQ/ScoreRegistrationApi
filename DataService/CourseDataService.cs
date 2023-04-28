using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.DataService
{
    public class CourseDataService
    {
        private Context _context;
        public CourseDataService(Context context){
            _context = context;
        }
        public IEnumerable<Course> get(){
            return _context.courses.ToList();
        }
        public Course? get(long id){
            var courseDb = _context.courses.Find(id);
            return courseDb;
        }

        public Course post(Course course){
            _context.courses.Add(course);
            _context.SaveChanges();
            return course;
        }
        public Course? update(Course course){
            var courseDb = _context.courses.Find(course.id);
            courseDb.name = course.name;
            _context.SaveChanges();
            return course;

        }
        public string delete(long id){
            var courseDb = _context.courses.Find(id);
            if(courseDb == null) return "Registro no existe";
            _context.courses.Remove(courseDb);
            _context.SaveChanges();
            return "Registro " + id + " se eliminó satisfactoriamente";

        }
    }
}