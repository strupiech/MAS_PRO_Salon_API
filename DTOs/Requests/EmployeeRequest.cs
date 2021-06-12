using System;
using System.Collections.Generic;
using MAS_PRO_Salon.Models;

namespace MAS_PRO_Salon.DTOs.Requests
{
    public class EmployeeRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public float HourlyRate { get; set; }

        public Seniority Seniority { get; set; }

        public List<EmployeeType> EmployeeTypes { get; set; }

        public string Territory { get; set; }

        public List<Specialization> Specializations { get; set; }

        public int? Manager { get; set; }

    }
}
