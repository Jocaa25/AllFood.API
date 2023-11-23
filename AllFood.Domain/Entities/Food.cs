using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllFood.Domain.Entities
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime ExpirationDate { get; set; }
        // Other related attributes and methods, if necessary
    }
}
