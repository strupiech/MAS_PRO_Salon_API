using System;
using System.Linq;
using System.Threading.Tasks;
using MAS_PRO_Salon.DTOs.Requests;
using MAS_PRO_Salon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MAS_PRO_Salon.Services
{
    public class EmployeeDbService : IEmployeeDbService
    {
        private readonly HairdressingSalonDbContext _context;

        public EmployeeDbService(HairdressingSalonDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Create(EmployeeRequest request)
        {
            int maxId = 0;

            Person person = await _context.People.Where(
                    p => p.PhoneNumber == request.PhoneNumber
                    && p.FirstName == request.FirstName
                    && p.LastName == request.LastName
                ).FirstOrDefaultAsync();

            if (person != null)
            {
                Employee existingEmployee = await _context.Employees.Where(
                        e => e.PersonID == person.PersonID
                    ).FirstOrDefaultAsync();

                if (existingEmployee != null)
                    return new OkObjectResult(existingEmployee);
            }
            else
                maxId = await _context.People.MaxAsync(p => p.PersonID);

            Address address = await _context.Addresses.Where(a => a.AddressID == 2).FirstOrDefaultAsync();

            Employee employee = new()
            {
                PersonID = maxId == 0 ? person.PersonID : maxId + 1,
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                EmployeeTypes = request.EmployeeTypes,
                HourlyRate = request.HourlyRate,
                Seniority = request.Seniority,
                Address = address,
                Territory = request.Territory,
                Specializations = request.Specializations,
                ManagerID = null
            };

            Employee manager = await _context.Employees.Where(
                        e => e.PersonID == (request.Manager == null ? 0 : request.Manager) 
                    ).FirstOrDefaultAsync();

            if (manager != null && manager.EmployeeTypes.Contains(EmployeeType.MANAGER)) {
                employee.ManagerID = manager.PersonID;
            }

            await _context.AddAsync(employee);
            await _context.SaveChangesAsync();

            return new OkObjectResult(employee);
        }

        public async Task<IActionResult> Get()
        {
            return new OkObjectResult(await _context.Employees.ToListAsync());
        }

        public async Task<IActionResult> Get(int id)
        {
            Employee employee = await _context.Employees.Where(p => p.PersonID == id).FirstOrDefaultAsync();

            if (employee == null)
                return new NotFoundResult();

            return new OkObjectResult(employee);
        }
    }
}
