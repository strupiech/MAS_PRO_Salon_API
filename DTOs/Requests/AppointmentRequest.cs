using System;
using MAS_PRO_Salon.Models;

namespace MAS_PRO_Salon.DTOs.Requests
{
    public class AppointmentRequest
    {
        public int ClientID { get; set; }

        public int ServiceID { get; set; }

        public int HairdresserID { get; set; }

        public DateTime AppointmentDate { get; set; }

        public Status Status { get; set; }
    }
}
