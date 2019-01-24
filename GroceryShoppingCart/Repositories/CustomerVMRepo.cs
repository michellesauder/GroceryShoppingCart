using GroceryShoppingCart.Models;
using GroceryShoppingCart.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.Repositories
{
    public class CustomerVMRepo
    {
        private GroceryCartContext db;

        public CustomerVMRepo(GroceryCartContext db)
        {
            this.db = db;
        }

        public IEnumerable<CustomerVM> GetAll()
        {

            IEnumerable<CustomerVM> esList
                = db.Customer.Where(es => es.CustomerId == es.CustomerId)
                    // Assign properties within the 'Select' statement.
                    // Notice how we 'must' use the 'EmployeeStoreVM' type.
                    .Select(es => new CustomerVM()
                    {
                        CustomerID = es.CustomerId,
                        LastName = es.LastName,
                        FirstName = es.FirstName,

                            // Handle null values. 1st option selected if T otherwise 2nd if F.


                            // Must handle null because a null exists for 
                            // unit_num in the database.
                            // Get integer if it exists otherwise get 0.
                        });
            return esList;
        }

    }
}
