using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace MAS_PRO_Salon.Models
{
    [Table("People")]
    public class Person
    {
        public Person()
        {
        }

        public int PersonID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}
