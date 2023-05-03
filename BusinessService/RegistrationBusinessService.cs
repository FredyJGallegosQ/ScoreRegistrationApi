using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.DataService;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.BusinessService
{
    public class RegistrationBusinessService
    {
        private RegistrationDataService _registrationDataService;
        public RegistrationBusinessService(RegistrationDataService registrationDataService){
            _registrationDataService = registrationDataService;
        }
        public IEnumerable<Registration> get(){
            return _registrationDataService.get();
        }
        public Registration? get(long id){
            return _registrationDataService.get(id);
        }
        public Registration? post(RegistrationVM registrationVM){
            var registrationDb = generateRegistrationVM(registrationVM);
            _registrationDataService.post(registrationDb);
            return registrationDb;
        }
        public Registration? update(RegistrationVM registrationVM){
            var registrationDb = generateRegistrationVM(registrationVM);
            if(registrationDb.id == 0 || registrationDb.psId == 0 || registrationDb.semesterId == 0|| registrationDb.studentId == 0) return null;
            _registrationDataService.update(registrationDb);
            return registrationDb;
        }
        public string delete(long id){
            return _registrationDataService.delete(id);
        }
        //------------MODULOS
        public Registration generateRegistrationVM(RegistrationVM registrationVM){
            var registrationDb = new Registration{
                semesterId = registrationVM.semesterId,
                studentId = registrationVM.studentId,
                psId = registrationVM.psId
            };
            return registrationDb;
        }
    }
}