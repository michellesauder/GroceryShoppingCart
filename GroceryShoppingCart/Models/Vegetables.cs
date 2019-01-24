using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryShoppingCart.Models
{
    public class Vegetables
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VegetableId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        //Navigation Properties
        //Child Tables
        public virtual ICollection<GroceryCart> GroceryCart { get; set; }

    }
}