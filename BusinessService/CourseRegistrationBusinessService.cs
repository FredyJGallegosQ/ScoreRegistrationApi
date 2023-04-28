using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.DataService;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.BusinessService
{
    public class CourseRegistrationBusinessService
    {
        private CourseRegistrationDataService _courseRegistrationDataService;
        public CourseRegistrationBusinessService(CourseRegistrationDataService CourseRegistrationDataService){
            _courseRegistrationDataService = CourseRegistrationDataService;
        }
        public IEnumerable<CourseRegistration> get(){
            return _courseRegistrationDataService.get();
        }
        public CourseRegistration? get(long id){
            return _courseRegistrationDataService.get(id);
        }
        public CourseRegistration? post(CourseRegistrationVM CourseRegistrationVM){
            if (CourseRegistrationVM.courseId == 0) return null;
            var CourseRegistration = generarCourseRegistrationVM(CourseRegistrationVM);
            var insertedCourseRegistration = _courseRegistrationDataService.post(CourseRegistration);
            return insertedCourseRegistration;
        }
        public CourseRegistration? update(CourseRegistrationVM CourseRegistrationVM){
            if(CourseRegistrationVM.id == 0 || CourseRegistrationVM.courseId == 0) return null;
            var CourseRegistration = generarCourseRegistrationVM(CourseRegistrationVM);
            var upadtedCourseRegistration = _courseRegistrationDataService.update(CourseRegistration);
            return upadtedCourseRegistration;
        }
        public string delete(long id){
            return _courseRegistrationDataService.delete(id);
        }

        //-----------MODULOS
        public CourseRegistration generarCourseRegistrationVM(CourseRegistrationVM CourseRegistrationVM){
            var CourseRegistration = new CourseRegistration(){
                id = CourseRegistrationVM.id,
                registrationId = CourseRegistrationVM.registrationId,
                courseId = CourseRegistrationVM.courseId,
                course = null,
                registration = null
            };
            return CourseRegistration;
        }
    }
}