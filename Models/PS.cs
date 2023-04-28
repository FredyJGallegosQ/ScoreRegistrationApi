using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
    public class PS
    {
        public long id{get; set;}
        public string name{get; set;}
        public long facultadId{get; set;}
        [ForeignKey(nameof(facultadId))]
        public Facultad? facultad{get; set;}
        public IEnumerable<Registration>? registrations{get; set;}

    }
    public class PSVM
    {
        public long id{get; set;}
        public string name{get; set;}
        public long facultadId{get; set;}
    }
}