using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.ViewModels
{
    public class OrderVM
    {
            public string NewClient { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public DateTime Time { get; set; }
            public string Location { get; set; }
    }
}
