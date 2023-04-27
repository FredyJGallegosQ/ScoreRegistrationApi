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
    public class TeacherController: ControllerBase
    {
        private Context _context;
        public TeacherController(Context context){
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Teacher> get(){
            return _context.teachers.ToList();
        }
        [HttpGet("{id}")]
        public Teacher? get(long id){
            var teacherDb = _context.teachers.Find(id);
            return teacherDb;
        }
        [HttpPost]
        public Teacher post(Teacher teacher){
            _context.teachers.Add(teacher);
            _context.SaveChanges();
            return teacher;
        }
        [HttpPut]
        public Teacher? update(Teacher teacher){
            var teacherDb = _context.teachers.Find(teacher.id);
            if(teacherDb == null) return null;
            teacherDb.name = teacher.name;
            teacherDb.lastname = teacher.lastname;
            teacherDb.age = teacher.age;
            teacherDb.email = teacher.email;
            _context.SaveChanges();
            return teacherDb;
        }
        [HttpDelete("{id}")]
        public string delete(long id){
            var teacherDb = _context.teachers.Find(id);
            if(teacherDb == null) return "No existe registro";
            _context.teachers.Remove(teacherDb);
            _context.SaveChanges();
            return "Registro " + id + " se eliminó satisfactoriamente";
        }
    }
}