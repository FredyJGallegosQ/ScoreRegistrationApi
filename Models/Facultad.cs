using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class Facultad
    {
        public long id{get; set;}
        public string name{get; set;}
        public IEnumerable<PS> pSs{get; set;}

    }
    public class FacultadVM
    {
        public long id{get; set;}
        public string name{get; set;}

    }
}