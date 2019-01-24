using GroceryShoppingCart.Models;
using GroceryShoppingCart.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.Repositories
{
    public class EmployeeVMRepo
    {
            private GroceryCartContext db;

            public EmployeeVMRepo(GroceryCartContext db)
            {
                this.db = db;
            }

            public IEnumerable<EmployeeVM> GetAll()
            {

                IEnumerable<EmployeeVM> esList
                    = db.Employee.Where(es => es.Branch == es.Branch)
                        // Assign properties within the 'Select' statement.
                        // Notice how we 'must' use the 'EmployeeStoreVM' type.
                        .Select(es => new EmployeeVM()
                        {
                            EmployeeID = es.EmployeeId,
                            LastName = es.LastName,
                            FirstName = es.FirstName,
                            Branch = es.Branch,

                        // Handle null values. 1st option selected if T otherwise 2nd if F.
                       

                        // Must handle null because a null exists for 
                        // unit_num in the database.
                        // Get integer if it exists otherwise get 0.
                        });
                return esList;
            }

        }
}
