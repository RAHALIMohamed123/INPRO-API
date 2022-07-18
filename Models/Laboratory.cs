using System.Collections.Generic;

namespace INPRO.API.Models
{
    public class Laboratory
    {
        public int Id { get; set; }
        public string LaboratoryCode { get; set; }
        public string LaboratoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}