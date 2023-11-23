using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllFood.Domain.Entities
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        // Outras propriedades relacionadas a pessoa física
        public List<Phone> Phones { get; set; }
       // public Address Address { get; set; }
    }

}
