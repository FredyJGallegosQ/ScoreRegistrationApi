using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegistroNotasApi.BusinessService;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseRegistrationController: ControllerBase
    {
        private CourseRegistrationBusinessService _courseRegistrationBusinessService;
        public CourseRegistrationController(CourseRegistrationBusinessService CourseRegistrationBusinessService){
            _courseRegistrationBusinessService = CourseRegistrationBusinessService;
        }
        [HttpGet]
        public IEnumerable<CourseRegistration> get(){
            return _courseRegistrationBusinessService.get();
        }
        [HttpGet("{id}")]
        public CourseRegistration? get(long id){
            return _courseRegistrationBusinessService.get(id);
        }
        [HttpPost]
        public CourseRegistration? post(CourseRegistrationVM CourseRegistration){
            return _courseRegistrationBusinessService.post(CourseRegistration);
        }
        [HttpPut]
        public CourseRegistration? update(CourseRegistrationVM CourseRegistration){
            return _courseRegistrationBusinessService.update(CourseRegistration);
        }
        [HttpDelete("{id}")]
        public string delete(long id){
            return _courseRegistrationBusinessService.delete(id);
        }
    }
}