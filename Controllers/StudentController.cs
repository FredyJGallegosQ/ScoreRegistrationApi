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
        [HttpPost]
        public Student post(Student student){
            _context.students.Add(student);
            _context.SaveChanges();
            return student;
        }
    }
}