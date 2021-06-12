using System;
using System.Threading.Tasks;
using MAS_PRO_Salon.DTOs.Requests;
using Microsoft.AspNetCore.Mvc;

namespace MAS_PRO_Salon.Services
{
    public interface IServiceDbService : IDbService
    {
        public Task<IActionResult> Create(ServiceRequest request);
    }
}
