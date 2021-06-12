using System;
namespace MAS_PRO_Salon.Models
{
    public class Address
    {
        public Address()
        {
        }

        public int AddressID { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string StreetNumber { get; set; }

        public int? FlatNumber { get; set; }

        public string PostalCode { get; set; }

    }
}
