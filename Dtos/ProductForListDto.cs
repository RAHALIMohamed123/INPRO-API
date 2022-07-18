namespace INPRO.API.Dtos
{
    public class ProductForListDto
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string DE { get; set; }
        public string Brand { get; set; }
        public string FormId { get; set; }
        public string Dosage { get; set; }
        public string Conditioning { get; set; }
        public bool Imported { get; set; }        
        public bool Refundable { get; set; }        
        public bool Psychotropic { get; set; } 
        public bool Thermolabile { get; set; } 
        public string ProductClass { get; set; } 
        public string TherapeuticClass { get; set; } 
        public string PharmacologicalClass { get; set; } 
        public bool Removed { get; set; }
        public bool Availible { get; set; }
        public string CreatedDateTime { get; set; }
        public string LastUpdatedTime { get; set; }
        public decimal PPA { get; set; }
        public decimal ReferencePrice { get; set; }
        public string SG { get; set; }
        public string LaboratoryName { get; set; }
        public string Dci { get; set; }
        public string PhotoUrl { get; set; }
    }
}