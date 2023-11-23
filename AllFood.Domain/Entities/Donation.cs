using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllFood.Domain.Entities
{
    public class Donation
    {
        public int DonationId { get; set; }
        public int DonorEstablishmentId { get; set; } // ID of the donating establishment
        public int ReceivingEstablishmentId { get; set; } // ID of the receiving establishment
        public DateTime DonationDateTime { get; set; }
        public string FoodDetails { get; set; }
        // Other related attributes and methods, if necessary
    }
}
