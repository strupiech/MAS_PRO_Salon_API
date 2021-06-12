using System;
using System.Collections.Generic;
using MAS_PRO_Salon.Models;

namespace MAS_PRO_Salon.DTOs.Requests
{
    public class ServiceRequest
    {
        public string Name { get; set; }

        public int Duration { get; set; }

        public float Price { get; set; }

        public string Details { get; set; }

        public ICollection<Employee> Hairdressers { get; set; }
    }
}
