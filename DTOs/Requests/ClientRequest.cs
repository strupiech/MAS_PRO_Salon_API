using System;
namespace MAS_PRO_Salon.DTOs.Requests
{
    public class ClientRequest
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int? Discount { get; set; }
    }
}
