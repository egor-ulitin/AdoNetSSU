using System.Collections.Generic;

namespace ThreeTierArchitecture.DAL.Entities
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
