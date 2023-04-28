using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegistroNotasApi.BusinessService;
using RegistroNotasApi.DataService;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlternativesController
    {
        private AlternativesBusinessService _alternativesBusinessService;
        public AlternativesController(AlternativesBusinessService alternativesBusinessService){
            _alternativesBusinessService = alternativesBusinessService;
        }
        [HttpGet]
        public IEnumerable<Alternatives> get(){
            return _alternativesBusinessService.get();
        }
        [HttpGet("{id}")]
        public Alternatives? get(long id){
            return _alternativesBusinessService.get(id);
        }
        [HttpPost]
        public Alternatives? post(AlternativesVM alternatives){
            return _alternativesBusinessService.post(alternatives);
        }
        [HttpPut]
        public Alternatives? update(AlternativesVM alternatives){
            return _alternativesBusinessService.update(alternatives);
        }
        [HttpDelete("{id}")]
        public string delete(long id){
            return _alternativesBusinessService.delete(id);
        }
    }
}