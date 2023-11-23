using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllFood.Domain.Entities
{
    public class Receiver
    {
        public int ReceiverId { get; set; }
        public string Name { get; set; }
        // Outras propriedades do receptor

        public Establishment Establishment { get; set; }
        public Phone Phone { get; set; }
        
    }

}
