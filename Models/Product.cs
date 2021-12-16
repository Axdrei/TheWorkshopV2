using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheWorkshopV2.Models
{
    public class Product
    {
        //Creates primary key Product ID, and edits the Display name
        [DisplayName("Product ID")]
        public int productID { get; set; }

        //Creates Product Image -- Image Name, and edits the Display name
        [DisplayName("Image Name")]
        public string productImage { get; set; }

        //Creates Product name string, and edits the Display name
        [DisplayName("Product Name")]
        public string productName { get; set; }

        //Creates Product Description string, and edits the Display name
        [DisplayName("Product Description")]
        public string productDesc { get; set; }

        //Creates Product Price double, and edits the Display name
        [DisplayName("Product Price")]
        public double productPrice { get; set; }

        //Creates a non-mapped IFormFile ImageFile -- Meaning it will not be in the database
        //IFormFile lets you store files such as images
        [NotMapped]
        [DisplayName("Product Picture")]
        public IFormFile ImageFile { get; set; }
    }
}
