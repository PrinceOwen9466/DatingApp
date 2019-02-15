using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class UserForRegisterDto
    {
        #region Properties
        [Required]
        public string Username { get; set; }// = string.Empty;
        
        [Required]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "You must specify a password between 8 and 32 characters.")]
        public string Password { get; set; }// = string.Empty;

        #endregion
    }
}