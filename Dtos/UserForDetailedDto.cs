using System;
using System.Collections.Generic;
using INPRO.API.Models;

namespace INPRO.API.Dtos
{
    public class UserForDetailedDto
    {
        
        public int Id { get; set; } 
        public string Username { get; set; }  
        public string ProfilId { get; set; }
        public int Age { get; set; }   
        public string City { get; set; }    
        public string Department  { get; set; }
        public string   Country { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotoForDetailedDto> Photos { get; set; }
        public string Gender { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}