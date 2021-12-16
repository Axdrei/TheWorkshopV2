using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheWorkshopV2.Models
{
    public class Order
    {
        //Creates a OrderID int with annotations declaring it the primary Key, and editing the DisplayName
        [Key]
        [DisplayName("Order ID")]
        public int OrderID { get; set; }

        //Creates a customerID string with annotations declaring it to be a foreign key from object IdentityUser and editing the DisplayName
        [DisplayName("Customer ID")]
        public string CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public IdentityUser User { get; set; }

        //Creates a ProductID int with annotations declaring it to be a foreign key from object Product and editing the DisplayName
        [DisplayName("Product ID")]
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        //Creates a DateTime DatePurchased which will store the date the product was purchased
        [DisplayName("Date Purchased")]
        public DateTime DatePurchased { get; set; }

    }
}
