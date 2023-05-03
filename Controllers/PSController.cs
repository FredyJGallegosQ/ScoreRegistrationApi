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
    public class PSController
    {
        private PSBusinessService _pSBussinesService;
        public PSController (PSBusinessService pSBussinesService){
            _pSBussinesService = pSBussinesService;
        }
        [HttpGet]
        public IEnumerable<PS> get(){
            return _pSBussinesService.get();
        }
        [HttpGet("{id}")]
        public PS? get(long id){
            return _pSBussinesService.get(id);
        }
        [HttpPost]
        public PS? post(PSVM psVM){
            return _pSBussinesService.post(psVM);
        }
        [HttpPut]
        public PS? update(PSVM psVM){
            return _pSBussinesService.update(psVM);
        }
        [HttpDelete("{id}")]
        public string delete(long id){
            return _pSBussinesService.delete(id);
        }
    }
}