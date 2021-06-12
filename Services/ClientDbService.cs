using System;
using System.Linq;
using System.Threading.Tasks;
using MAS_PRO_Salon.DTOs.Requests;
using MAS_PRO_Salon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MAS_PRO_Salon.Services
{
    public class ClientDbService : IClientDbService
    {
        private readonly HairdressingSalonDbContext _context;

        public ClientDbService(HairdressingSalonDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Create(ClientRequest request)
        {
            Person person = await _context.People.Where(
                    p => p.PhoneNumber == request.PhoneNumber
                    && p.FirstName == request.FirstName
                    && p.LastName == request.LastName
                ).FirstOrDefaultAsync();

            int maxId = 0;
            if (person == null)
                maxId = await _context.People.MaxAsync(p => p.PersonID);

            Client client = new()
            {
                PersonID = maxId == 0 ? person.PersonID : maxId + 1,
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                Discount = request.Discount
            };

            await _context.AddAsync(client);
            await _context.SaveChangesAsync();

            return new OkObjectResult(client);
        }

        public async Task<IActionResult> Get()
        {
            return new OkObjectResult(await _context.Clients.ToListAsync());
        }

        public async Task<IActionResult> Get(int id)
        {
            Client client = await _context.Clients.Where(c => c.PersonID == id).FirstOrDefaultAsync();

            if (client == null)
                return new NotFoundResult();

            return new OkObjectResult(client);
        }
    }
}
