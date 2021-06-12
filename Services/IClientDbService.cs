using System;
using System.Threading.Tasks;
using MAS_PRO_Salon.DTOs.Requests;
using MAS_PRO_Salon.Models;
using Microsoft.AspNetCore.Mvc;

namespace MAS_PRO_Salon.Services
{
    public interface IClientDbService : IDbService
    {
        
        public Task<IActionResult> Create(ClientRequest request);

    }
}
