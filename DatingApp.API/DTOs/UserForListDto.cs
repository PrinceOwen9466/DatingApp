using System;
using DatingApp.API.Models;

namespace DatingApp.API.DTOs
{
    public class UserForListDto
    {
        #region Properties
        public int Id { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set;}
        public string KnowAs { get; set;}
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Photo MainPhoto { get; set; }
        #endregion
    }
}