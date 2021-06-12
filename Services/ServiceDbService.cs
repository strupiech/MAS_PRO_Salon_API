using System;
using System.Linq;
using System.Threading.Tasks;
using MAS_PRO_Salon.DTOs.Requests;
using MAS_PRO_Salon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MAS_PRO_Salon.Services
{
    public class ServiceDbService : IServiceDbService
    {
        private readonly HairdressingSalonDbContext _context;

        public ServiceDbService(HairdressingSalonDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Create(ServiceRequest request)
        {
            Service service = new()
            {
                Name = request.Name,
                Duration = request.Duration,
                Price = request.Price,
                Details = request.Details,
                Hairdressers = request.Hairdressers
            };

            await _context.AddAsync(service);
            await _context.SaveChangesAsync();

            return new OkObjectResult(service);
        }

        public async Task<IActionResult> Get()
        {
            return new OkObjectResult(await _context.Services.ToListAsync());
        }

        public async Task<IActionResult> Get(int id)
        {
            Service service = await _context.Services.Where(c => c.ServiceID == id).FirstOrDefaultAsync();

            if (service == null)
                return new NotFoundResult();

            return new OkObjectResult(service);
        }
    }
}
