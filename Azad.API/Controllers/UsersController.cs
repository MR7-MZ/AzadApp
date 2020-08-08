using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Azad.API.Data;
using Azad.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Azad.API.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IAzadRepository _repo;
        private readonly IMapper _mapper;
        public UsersController(IAzadRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _repo.GetUsers();

            var userToReturn =_mapper.Map<IEnumerable<UserForListDto>>(users);

            return Ok(userToReturn);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _repo.GetUser(id);

            var userToReturn =_mapper.Map<UserForDetailsDto>(user);

            return Ok(userToReturn);
        }
    }
}