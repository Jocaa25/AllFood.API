using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AllFood.Domain.Entities
{
    public class Establishment
    {
        public int EstablishmentId { get; set; }
        public string EstablishmentName { get; set; }
        public string CNPJ { get; set; }
        // Outras propriedades relacionadas a pessoa jurídica
        public List<Phone> Phones { get; set; }
    }
    // Other related attributes and methods, if necessary
}

