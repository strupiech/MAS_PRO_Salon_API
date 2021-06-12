using System;
using System.Linq;
using System.Threading.Tasks;
using MAS_PRO_Salon.DTOs.Requests;
using MAS_PRO_Salon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MAS_PRO_Salon.Services
{
    public class AppointmentDbService : IAppointmentDbService
    {
        private readonly HairdressingSalonDbContext _context;

        public AppointmentDbService(HairdressingSalonDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Create(AppointmentRequest request)
        {
            Appointment appointment = new()
            {
                ServiceID = request.ServiceID,
                ClientID = request.ClientID,
                AppointmentDate = request.AppointmentDate,
                HairdresserID = request.HairdresserID,
                Status = request.Status
            };

            await _context.AddAsync(appointment);
            await _context.SaveChangesAsync();

            return new OkObjectResult(appointment);
        }

        public async Task<IActionResult> Get()
        {
            return new OkObjectResult(await _context.Appointments.ToListAsync());
        }

        public async Task<IActionResult> Get(int id)
        {
            Appointment appointment = await _context.Appointments.Where(a => a.AppointmentID == id).FirstOrDefaultAsync();

            if (appointment == null)
                return new NotFoundResult();

            return new OkObjectResult(appointment);
        }
    }
}
