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
    public class ChapterController: ControllerBase
    {
        private Context _context;
        public ChapterController(Context context){
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Chapter> get(){
            return _context.chapters.ToList();
        }
        [HttpGet("{id}")]
        public Chapter? get(long id){
            var ChapterDb = _context.chapters.Find(id);
            return ChapterDb;
        }
        [HttpPost]
        public Chapter post(Chapter chapter){
            _context.chapters.Add(chapter);
            _context.SaveChanges();
            return chapter;
        }
        [HttpPut]
        public Chapter? update(Chapter chapter){
            var ChapterDb = _context.chapters.Find(chapter.id);
            if(ChapterDb == null) return null;
            ChapterDb.name = chapter.name;
            ChapterDb.courseId = chapter.courseId;
            _context.SaveChanges();
            return chapter;
        }
        [HttpDelete("{id}")]
        public string delete(long id){
            var ChapterDb = _context.chapters.Find(id);
            if(ChapterDb == null) return "Registro no existe";
            _context.chapters.Remove(ChapterDb);
            _context.SaveChanges();
            return "Registro " + id + " se eliminó satisfactoriamente";
        }
    }
}