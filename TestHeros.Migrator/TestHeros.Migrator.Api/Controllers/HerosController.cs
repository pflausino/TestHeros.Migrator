using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestHeros.Migrator.Domain.Interfaces;

namespace TestHeros.Migrator.Api.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class HerosController : ControllerBase
    {
        private readonly IHeroRepository _repo;

        public HerosController(IHeroRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetHeroAsync()
        {
            var heros =  _repo.GetAll();
            return Ok(heros);
        }
    }
}