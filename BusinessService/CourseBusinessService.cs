using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.DataService;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.BusinessService
{
    public class CourseBusinessService
    {
        private CourseDataService _courseDataService;
        public CourseBusinessService(CourseDataService courseDataService){
            _courseDataService = courseDataService;
        }
        public IEnumerable<Course> get(){
            return _courseDataService.get();
        }
        public Course? get(long id){
            return _courseDataService.get(id);
        }
        public Course? post(CourseVM CourseVM){
            if (CourseVM.id == 0) return null;
            var Course = generarCourseVM(CourseVM);
            var insertedCourse = _courseDataService.post(Course);
            return insertedCourse;
        }
        public Course? update(CourseVM CourseVM){
            if(CourseVM.id == 0) return null;
            var Course = generarCourseVM(CourseVM);
            var upadtedCourse = _courseDataService.update(Course);
            return upadtedCourse;
        }
        public string delete(long id){
            return _courseDataService.delete(id);
        }

        //-----------MODULOS
        public Course generarCourseVM(CourseVM CourseVM){
            var Course = new Course(){
                id = CourseVM.id,
                name = CourseVM.name
            };
            return Course;
        }
    }
}