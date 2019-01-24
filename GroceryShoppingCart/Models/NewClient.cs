using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryShoppingCart.Models
{
        public class NewClient
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            public virtual ICollection<OrderRequest> OrderRequests { get; set; }
        }


}
