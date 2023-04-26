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
        [HttpPost]
        public Teacher post(Teacher teacher){
            _context.teachers.Add(teacher);
            _context.SaveChanges();
            return teacher;
        }
    }
}