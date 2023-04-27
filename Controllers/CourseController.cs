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
    public class CourseController: ControllerBase
    {
        private Context _context;
        public CourseController(Context context){
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Course> get(){
            return _context.courses.ToList();
        }
        [HttpGet("{id}")]
        public Course? get(long id){
            var courseDb = _context.courses.Find(id);
            return courseDb;
        }
        [HttpPost]
        public Course post(Course course){
            _context.courses.Add(course);
            _context.SaveChanges();
            return course;
        }
        [HttpPut]
        public Course? update(Course course){
            var courseDb = _context.courses.Find(course.id);
            courseDb.name = course.name;
            _context.SaveChanges();
            return course;

        }
        [HttpDelete("{id}")]
        public string delete(long id){
            var courseDb = _context.courses.Find(id);
            if(courseDb == null) return "Registro no existe";
            _context.courses.Remove(courseDb);
            _context.SaveChanges();
            return "Registro " + id + " se eliminó satisfactoriamente";

        }
    }
}