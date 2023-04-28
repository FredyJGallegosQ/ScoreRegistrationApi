using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.DataService
{
    public class ExamDataService
    {
        private Context _context;
        public ExamDataService (Context context){
            _context = context;
        }
        public IEnumerable<Exam> get(){
            return _context.exams.ToList();
        }
        public Exam? get(long id){
            var examDb = _context.exams.Find(id);
            return examDb;
        }
        public Exam post(Exam exam){
            _context.exams.Add(exam);
            _context.SaveChanges();
            return exam;
        }
        public Exam? update(Exam exam){
            var examDb = _context.exams.Find(exam.id);
            if(examDb == null) return null;
            examDb.fecha = exam.fecha;
            examDb.score = exam.score;
            examDb.chapterId = exam.chapterId;
            _context.SaveChanges();
            return exam;
        }
        public string delete(long id){
            var ExamDb = _context.exams.Find(id);
            if(ExamDb == null) return "Registro no existe";
            _context.exams.Remove(ExamDb);
            _context.SaveChanges();
            return "Registro " + id + " se eliminó satisfactoriamente";
        }
    }
    
}