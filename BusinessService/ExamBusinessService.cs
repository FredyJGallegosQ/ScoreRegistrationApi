using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.DataService;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.BusinessService
{
    public class ExamBusinessService
    {
        private ExamDataService _examDataService;
        public ExamBusinessService(ExamDataService examDataService){
            _examDataService = examDataService;
        }
        public IEnumerable<Exam> get(){
            return _examDataService.get();
        }
        public Exam? get(long id){
            return _examDataService.get(id);
        }
        public Exam? post(ExamVM examVM){
            if (examVM.chapterId == 0) return null;
            var exam = generarexamVM(examVM);
            var insertedexam = _examDataService.post(exam);
            return insertedexam;
        }
        public Exam? update(ExamVM examVM){
            if(examVM.id == 0 || examVM.chapterId == 0) return null;
            var exam = generarexamVM(examVM);
            var upadtedexam = _examDataService.update(exam);
            return upadtedexam;
        }
        public string delete(long id){
            return _examDataService.delete(id);
        }

        //-----------MODULOS
        public Exam generarexamVM(ExamVM examVM){
            var exam = new Exam(){
                id = examVM.id,
                fecha = examVM.fecha,
                score = examVM.score,
                chapterId = examVM.chapterId,
                chapter = null
            };
            return exam;
        }
    }
}