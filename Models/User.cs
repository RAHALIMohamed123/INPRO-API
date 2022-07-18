using System;
using System.Collections.Generic;

namespace INPRO.API.Models
{
    public class User
    {
        public int Id { get; set; } 
        public string Username { get; set; }  
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }  
        public int UserInfoId { get; set; }
        public string ProfilId { get; set; }
        public DateTime DateOfBirth { get; set; }   
        public DateTime LastActive { get; set; }
        public string City { get; set; }    
        public string Department  { get; set; }
        public string   Country { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public string Gender { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}