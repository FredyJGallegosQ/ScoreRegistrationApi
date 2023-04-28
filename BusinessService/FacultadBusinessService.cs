using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.DataService;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.BusinessService
{
    public class FacultadBusinessService
    {
        private FacultadDataService _facultadDataService;
        public FacultadBusinessService(FacultadDataService facultadDataService){
            _facultadDataService = facultadDataService;
        }
        public IEnumerable<Facultad> get(){
            return _facultadDataService.get();
        }
        public Facultad? get(long id){
            return _facultadDataService.get(id);
        }
        public Facultad? post(FacultadVM facultadVM){
            var facultad = generarfacultadVM(facultadVM);
            var insertedfacultad = _facultadDataService.post(facultad);
            return insertedfacultad;
        }
        public Facultad? update(FacultadVM facultadVM){
            if(facultadVM.id == 0) return null;
            var facultad = generarfacultadVM(facultadVM);
            var upadtedfacultad = _facultadDataService.update(facultad);
            return upadtedfacultad;
        }
        public string delete(long id){
            return _facultadDataService.delete(id);
        }

        //-----------MODULOS
        public Facultad generarfacultadVM(FacultadVM facultadVM){
            var facultad = new Facultad(){
                id = facultadVM.id,
                name = facultadVM.name
            };
            return facultad;
        }
    }
}