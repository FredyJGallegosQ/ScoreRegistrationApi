using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroNotasApi.DataService;
using RegistroNotasApi.Models;

namespace RegistroNotasApi.BusinessService
{
    public class AlternativesBusinessService
    {
        private AlternativesDataService _altenativesDataService;
        public AlternativesBusinessService(AlternativesDataService alternativesDataService){
            _altenativesDataService = alternativesDataService;
        }
        public IEnumerable<Alternatives> get(){
            return _altenativesDataService.get();
        }
        public Alternatives? get(long id){
            return _altenativesDataService.get(id);
        }
        // public Alternatives? post(Alternatives alternatives){
        //     return _altenativesDataService.post(alternatives);
        // }
        public Alternatives? post(AlternativesVM alternativesVM){
            //if (alternativesVM.questionId == 0) throw new Exception("Id == 0");
            if (alternativesVM.questionId == 0) return null;
            var alternativesV = new Alternatives(){
                alternative1 = alternativesVM.alternative1,
                alternative2 = alternativesVM.alternative2,
                alternative3 = alternativesVM.alternative3,
                alternative4 = alternativesVM.alternative4,
                alternative5 = alternativesVM.alternative5,
                answer = alternativesVM.answer,
                questionId = alternativesVM.questionId,
                question = null
            };
            var insertedAlternatives = _altenativesDataService.post(alternativesV);
            // var showAlternatives = new AlternativesVM(){
            //     alternative1 = insertedAlternatives.alternative1,
            //     alternative2 = insertedAlternatives.alternative2,
            //     alternative3 = insertedAlternatives.alternative3,
            //     alternative4 = insertedAlternatives.alternative4,
            //     alternative5 = insertedAlternatives.alternative5,
            //     answer = insertedAlternatives.answer,
            //     questionId = insertedAlternatives.questionId
            // };
            // return showAlternatives;
            return insertedAlternatives;
            //return _altenativesDataService.post(alternativesV);
        }
        public Alternatives? update(Alternatives alternatives){
            return _altenativesDataService.update(alternatives);
        }
        public string delete(long id){
            return _altenativesDataService.delete(id);
        }
    }
}