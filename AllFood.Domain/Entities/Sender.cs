using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllFood.Domain.Entities
{
    public class Sender
    {
        public int SenderId { get; set; }
        public string Name { get; set; }
        // Outras propriedades do remetente

        public Establishment Establishment { get; set; }
    }
}
