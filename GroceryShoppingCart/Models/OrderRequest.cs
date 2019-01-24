using System;
using System.ComponentModel.DataAnnotations;

namespace GroceryShoppingCart.Models
{
    public class OrderRequest
    {
            [Key]
            public int Id { get; set; }
            public DateTime Time { get; set; }
            public string Location { get; set; }

            public virtual NewClient NewClient { get; set; }


    }
}