using System;
using MAS_PRO_Salon.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MAS_PRO_Salon.DTOs.Requests;

namespace MAS_PRO_Salon.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientDbService _dbService;

        public ClientController(IClientDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await _dbService.Get();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return await _dbService.Get(id);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ClientRequest client)
        {
            return await _dbService.Create(client);
        }

    }
}
