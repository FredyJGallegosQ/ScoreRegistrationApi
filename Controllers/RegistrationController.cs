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
    public class RegistrationController
    {
        private RegistrationBusinessService _registrationBusinessService;
        public RegistrationController(RegistrationBusinessService registrationBusinessService){
            _registrationBusinessService = registrationBusinessService;
        }
        [HttpGet]
        public IEnumerable<Registration> get(){
            return _registrationBusinessService.get();
        }
        [HttpGet("{id}")]
        public Registration? get(long id){
            return _registrationBusinessService.get(id);
        }
        [HttpPost]
        public Registration? post(RegistrationVM registrationVM){
            return _registrationBusinessService.post(registrationVM);
        }
        [HttpPut]
        public Registration? update(RegistrationVM registrationVM){
            return _registrationBusinessService.update(registrationVM);
        }
        [HttpDelete("{id}")]
        public string delete(long id){
            return _registrationBusinessService.delete(id);
        }
    }
}