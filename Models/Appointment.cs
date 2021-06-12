using System;
namespace MAS_PRO_Salon.Models
{
    public enum Status
    {
        NOT_CONFIRMED,
        CONFIRMED,
        PERFORMED,
        NOT_PERFORMED
    }

    public class Appointment
    {
        public Appointment()
        {
        }

        public int AppointmentID { get; set; }

        public int ServiceID { get; set; }

        public Service Service { get; set; }

        public int ClientID { get; set; }

        public Client Client { get; set; }

        public DateTime AppointmentDate { get; set; }

        public int HairdresserID { get; set; }

        public Employee Hairdresser { get; set; }

        public Address Address { get; set; }

        public Status Status { get; set; }

    }
}
