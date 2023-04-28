using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegistroNotasApi.Models;
using RegistroNotasApi.BusinessService;

namespace RegistroNotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController: ControllerBase
    {
        private CourseBusinessService _courseBusinessService;
        public CourseController(CourseBusinessService courseBusinessService ){
            _courseBusinessService = courseBusinessService;
        }
        [HttpGet]
        public IEnumerable<Course> get(){
            return _courseBusinessService.get();
        }
        [HttpGet("{id}")]
        public Course? get(long id){
            return _courseBusinessService.get(id);
        }
        [HttpPost]
        public Course? post(CourseVM Course){
            return _courseBusinessService.post(Course);
        }
        [HttpPut]
        public Course? update(CourseVM Course){
            return _courseBusinessService.update(Course);
        }
        [HttpDelete("{id}")]
        public string delete(long id){
            return _courseBusinessService.delete(id);
        }
    }
}