using System;
namespace MAS_PRO_Salon.Models
{
    public class ProductOrder
    {
        public ProductOrder()
        {
        }

        public int OrderID { get; set; }

        public Order Order { get; set; }

        public int ProductID { get; set; }

        public Product Product { get; set; }

        public float Amount { get; set; }
    }
}
