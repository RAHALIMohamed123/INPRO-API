using System.Collections.Generic;
using System.Linq;
using System.Text;
using INPRO.API.Models;
using Newtonsoft.Json;

namespace INPRO.API.Data
{
    public class Seed
    {
        public static void SeedUsers(DataContext context)
        {
            if(!context.Users.Any()) 
            {
                var userData = System.IO.File.ReadAllText("Data/UserSeedData.json");
                var users = JsonConvert.DeserializeObject<List<User>>(userData);

                foreach (var user in users) 
                {
                    byte[] passwordHash, passwordSalt;
                    CreatePasswordHash("password", out passwordHash, out passwordSalt);
                    user.PasswordHash = passwordHash;
                    user.PasswordSalt = passwordSalt;
                    user.City = user.City;
                    user.Username = user.Username;
                    user.ProfilId =  user.ProfilId;
                    user.UserInfoId =  user.UserInfoId;

                    context.Users.Add(user);
                }

                context.SaveChanges();
            }
        
            
                   
        }
         private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
            {
                using (var hmac = new System.Security.Cryptography.HMACSHA512())
                {
                    passwordSalt = hmac.Key;
                    passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                }
                 
            }
        
    }
}