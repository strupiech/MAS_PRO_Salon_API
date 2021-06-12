using System;
namespace MAS_PRO_Salon.Models
{
    public class Order
    {
        public Order()
        {
        }

        public int OrderID { get; set; }

        public string Type { get; set; }

        public Address Address { get; set; }

        public int EmployeeID { get; set; }

        public Employee Employee { get; set; }
    }
}
