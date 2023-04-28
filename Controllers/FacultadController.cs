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
    public class FacultadController
    {
        private FacultadBusinessService _facultadBusinessService;
        public FacultadController(FacultadBusinessService facultadBusinessService){
            _facultadBusinessService = facultadBusinessService;
        }
        [HttpGet]
        public IEnumerable<Facultad> get(){
            return _facultadBusinessService.get();
        }
        [HttpGet("{id}")]
        public Facultad? get(long id){
            return _facultadBusinessService.get(id);
        }
        [HttpPost]
        public Facultad? post(FacultadVM facultad){
            return _facultadBusinessService.post(facultad);
        }
        [HttpPut]
        public Facultad? update(FacultadVM facultad){
            return _facultadBusinessService.update(facultad);
        }
        [HttpDelete("{id}")]
        public string delete(long id){
            return _facultadBusinessService.delete(id);
        }
    }
}