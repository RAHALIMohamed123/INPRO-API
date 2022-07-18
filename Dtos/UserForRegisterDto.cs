using System.ComponentModel.DataAnnotations;

namespace INPRO.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }   
        [Required]
        [StringLength(8, MinimumLength = 4 , ErrorMessage = "You must specify password between 4 and 8 Characters")] 
        public string Password { get; set; }    
        [Required]
        public int UserInfoId { get; set; }
        [Required]
        public string ProfilId { get; set; }
    }
}