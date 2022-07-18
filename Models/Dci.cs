using System.Collections.Generic;

namespace INPRO.API.Models
{
    public class Dci
    {
        public int Id { get; set; }
        public string DciCode { get; set; }
        public string DciName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}