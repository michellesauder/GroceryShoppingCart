using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryShoppingCart.Models
{
    public class GroceryCart
    {

        //Key notation to assign Primary Key
        //Optional Column Attribute
        [Key, Column(Order = 0)]
        public int DrinkId { get; set; }

        [Key, Column(Order = 1)]
        public int FruitId { get; set; }

        [Key, Column(Order = 2)]
        public int GrainId { get; set; }

        [Key, Column(Order = 3)]
        public int MeatId { get; set; }

        [Key, Column(Order = 4)]
        public int VegetableId { get; set; }

        [Key, Column(Order = 5)]
        public int EmployeeId { get; set; }

        [Key, Column(Order = 6)]
        public int CustomerId { get; set; }

        //Navigation Properties
        //Parent Tables
        public virtual Drinks Drinks { get; set; }
        public virtual Fruits Fruits { get; set; }
        public virtual Grain Grain { get; set; }
        public virtual Meat Meat { get; set; }
        public virtual Vegetables Vegetables { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Customer Customer { get; set; }


    }
}