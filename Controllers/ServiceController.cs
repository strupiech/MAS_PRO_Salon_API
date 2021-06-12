using System;
using System.Threading.Tasks;
using MAS_PRO_Salon.DTOs.Requests;
using MAS_PRO_Salon.Services;
using Microsoft.AspNetCore.Mvc;

namespace MAS_PRO_Salon.Controllers
{
    [Route("api/services")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceDbService _dbService;

        public ServiceController(IServiceDbService dbService)
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
        public async Task<IActionResult> Create(ServiceRequest request)
        {
            return await _dbService.Create(request);
        }
    }
}
