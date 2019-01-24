using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.Models
{
    public class Drinks
    {
            //Key notation to assign Primary Key
            //Optional DatabaseGenerated Attribute
            [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
            public int DrinkId { get; set; }
            public string Description { get; set; }
            public double Price { get; set; }
            

            //Navigation Properties
            //Child Tables
            public virtual ICollection<GroceryCart> GroceryCart { get; set; }
        }

    }

