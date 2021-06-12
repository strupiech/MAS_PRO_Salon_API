using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MAS_PRO_Salon.Services
{
    public interface IDbService
    {
        public Task<IActionResult> Get();
        public Task<IActionResult> Get(int id);
    }
}
