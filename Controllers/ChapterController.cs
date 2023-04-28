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
    public class ChapterController: ControllerBase
    {
        private ChapterBusinessService _chapterBusinessService;
        public ChapterController(ChapterBusinessService chapterBusinessService){
            _chapterBusinessService = chapterBusinessService;
        }
        [HttpGet]
        public IEnumerable<Chapter> get(){
            return _chapterBusinessService.get();
        }
        [HttpGet("{id}")]
        public Chapter? get(long id){
            return _chapterBusinessService.get(id);
        }
        [HttpPost]
        public Chapter? post(ChapterVM Chapter){
            return _chapterBusinessService.post(Chapter);
        }
        [HttpPut]
        public Chapter? update(ChapterVM Chapter){
            return _chapterBusinessService.update(Chapter);
        }
        [HttpDelete("{id}")]
        public string delete(long id){
            return _chapterBusinessService.delete(id);
        }
    }
}