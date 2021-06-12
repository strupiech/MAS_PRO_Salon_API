using System;
using System.Threading.Tasks;
using MAS_PRO_Salon.DTOs.Requests;
using Microsoft.AspNetCore.Mvc;

namespace MAS_PRO_Salon.Services
{
    public interface IEmployeeDbService : IDbService
    {
   
        public Task<IActionResult> Create(EmployeeRequest request);

    }
}
