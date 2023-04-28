using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.DataService;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.BusinessService
{
    public class ChapterBusinessService
    {
        private ChapterDataService _chapterDataService;
        public ChapterBusinessService(ChapterDataService chapterDataService){
            _chapterDataService = chapterDataService;
        }
        public IEnumerable<Chapter> get(){
            return _chapterDataService.get();
        }
        public Chapter? get(long id){
            return _chapterDataService.get(id);
        }
        public Chapter? post(ChapterVM ChapterVM){
            if (ChapterVM.courseId == 0) return null;
            var Chapter = generarChapterVM(ChapterVM);
            var insertedChapter = _chapterDataService.post(Chapter);
            return insertedChapter;
        }
        public Chapter? update(ChapterVM ChapterVM){
            if(ChapterVM.id == 0 || ChapterVM.courseId == 0) return null;
            var Chapter = generarChapterVM(ChapterVM);
            var upadtedChapter = _chapterDataService.update(Chapter);
            return upadtedChapter;
        }
        public string delete(long id){
            return _chapterDataService.delete(id);
        }

        //-----------MODULOS
        public Chapter generarChapterVM(ChapterVM ChapterVM){
            var Chapter = new Chapter(){
                id = ChapterVM.id,
                name = ChapterVM.name,
                courseId = ChapterVM.courseId,
                course = null
            };
            return Chapter;
        }
    }
}