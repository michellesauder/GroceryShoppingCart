using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.ViewModels
{
    public class CustomerVM
    {
        [DisplayName("Customer ID")] // Give nice label name for CRUD.
        public int CustomerID { get; set; }
        [DisplayName("Last Name")]   // Give nice label name for CRUD.
        public string LastName { get; set; }
        [DisplayName("First Name")]  // Give nice label name for CRUD.
        public string FirstName { get; set; }

    }
}
