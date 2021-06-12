using System;
namespace MAS_PRO_Salon.Models
{
    public class Product
    {
        public Product()
        {
        }

        public int ProductID { get; set; }

        public float Price { get; set; }

        public string Name { get; set; }

        public string Details { get; set; }
    }
}
