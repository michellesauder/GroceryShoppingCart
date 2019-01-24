using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.ViewModels
{
    public class EmployeeVM
    {
            [DisplayName("Employee ID")] // Give nice label name for CRUD.
            public int EmployeeID { get; set; }
            [DisplayName("Last Name")]   // Give nice label name for CRUD.
            public string LastName { get; set; }
            [DisplayName("First Name")]  // Give nice label name for CRUD.
            public string FirstName { get; set; }
            public string Branch { get; set; }
        }
}
