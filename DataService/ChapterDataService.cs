using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.DataService
{
    public class ChapterDataService
    {
        private Context _context;
        public ChapterDataService(Context context){
            _context = context;
        }
        public IEnumerable<Chapter> get(){
            return _context.chapters.ToList();
        }
        public Chapter? get(long id){
            var ChapterDb = _context.chapters.Find(id);
            return ChapterDb;
        }
        public Chapter post(Chapter chapter){
            _context.chapters.Add(chapter);
            _context.SaveChanges();
            return chapter;
        }
        public Chapter? update(Chapter chapter){
            var ChapterDb = _context.chapters.Find(chapter.id);
            if(ChapterDb == null) return null;
            ChapterDb.name = chapter.name;
            ChapterDb.courseId = chapter.courseId;
            _context.SaveChanges();
            return chapter;
        }
        public string delete(long id){
            var ChapterDb = _context.chapters.Find(id);
            if(ChapterDb == null) return "Registro no existe";
            _context.chapters.Remove(ChapterDb);
            _context.SaveChanges();
            return "Registro " + id + " se eliminó satisfactoriamente";
        }
    }
}