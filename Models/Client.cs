using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAS_PRO_Salon.Models
{
    [Table("Clients")]
    public class Client : Person
    {
        public Client()
        {
        }

        public int? Discount { get; set; }
    }
}
