using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DatingApp.API.Data;
using DatingApp.API.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        #region Properties
        IDatingRepository Repo { get; set; }
        IMapper Mapper { get; set; }
        #endregion

        #region Constructors
        public UsersController(IDatingRepository repo, IMapper mapper)
        {
            Repo = repo;
            Mapper = mapper;
        }
        #endregion

        #region Methods

        #region REST Conventions
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await Repo.GetUsers();
            var usersToReturn = Mapper.Map<IEnumerable<UserForListDto>>(users);
            return Ok(usersToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await Repo.GetUser(id);
            var returnUser = Mapper.Map<UserForDetailDto>(user);
            return Ok(returnUser);
        }
        #endregion

        #endregion
    }
}