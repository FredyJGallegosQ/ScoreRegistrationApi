using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.DataService;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.BusinessService
{
    public class PSBusinessService
    {
        private PSDataService _pSDataService;
        public PSBusinessService(PSDataService pSDataService){
            _pSDataService = pSDataService;
        }
        public IEnumerable<PS> get(){
            return _pSDataService.get();
        }
        public PS? get(long id){
            return _pSDataService.get(id);
        }
        public PS? post(PSVM pSVM){
            var ps = generarPSVM(pSVM);
            _pSDataService.post(ps);
            return ps;
        }
        public PS? update(PSVM pSVM){
            if(pSVM.id == 0) return null;
            var ps = generarPSVM(pSVM);
            _pSDataService.update(ps);
            return ps;
        }
        public string delete(long id){
            return _pSDataService.delete(id);
        }
        //----------MODULOS
        public PS generarPSVM(PSVM pSVM){
            var ps = new PS(){
                id = pSVM.id,
                name = pSVM.name,
                facultadId = pSVM.facultadId
            };
            return ps;
        }
    }
}