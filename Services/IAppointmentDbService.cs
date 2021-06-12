using System;
using System.Threading.Tasks;
using MAS_PRO_Salon.DTOs.Requests;
using Microsoft.AspNetCore.Mvc;

namespace MAS_PRO_Salon.Services
{
    public interface IAppointmentDbService : IDbService
    {
        public Task<IActionResult> Create(AppointmentRequest request);
    }
}
