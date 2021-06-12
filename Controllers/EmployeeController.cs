using System;
using System.Threading.Tasks;
using MAS_PRO_Salon.DTOs.Requests;
using MAS_PRO_Salon.Services;
using Microsoft.AspNetCore.Mvc;

namespace MAS_PRO_Salon.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeDbService _dbService;

        public EmployeeController(IEmployeeDbService dbService)
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
        public async Task<IActionResult> Create(EmployeeRequest employee)
        {
            return await _dbService.Create(employee);
        }

    }
}
