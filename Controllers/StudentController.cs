using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.Controllers
{
    [ApiController]
    [Route("controller")]
    public class StudentController: ControllerBase
    {
        private Context _context;
        public StudentController(Context contex){
            _context = contex;
        }
        [HttpGet]
        public IEnumerable<Student> get(){
            return _context.students.ToList();
        }
        [HttpGet("{id}")]
        public Student? get(long id){
            var studentDb = _context.students.Find(id);
            if(studentDb == null) return null;
            return studentDb;
        }
        [HttpPost]
        public Student post(Student student){
            _context.students.Add(student);
            _context.SaveChanges();
            return student;
        }
        [HttpPut]
        public Student? update(Student student){
            var studentDb = _context.students.Find(student.id);
            if(studentDb == null) return null;
            studentDb.name = student.name;
            studentDb.lastname = student.lastname;
            studentDb.age = student.age;
            studentDb.email = student.email;
            _context.SaveChanges();
            return studentDb;
        }
        [HttpDelete("{id}")]
        public string delete(long id){
            var studentDb = _context.students.Find(id);
            if(studentDb == null) return "No existe registro";
            _context.students.Remove(studentDb);
            _context.SaveChanges();
            return "Registro " + id + " se eliminó satisfactoriamente";
        }
    }
}