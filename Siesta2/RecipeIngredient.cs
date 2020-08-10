using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siesta2
{
    public class RecipeIngredient
    {
        public int Id { get; set; }
        public decimal Quantity { get; set; }
        public int Id_Measure { get; set; }
        public int Id_Recipe { get; set; }
        public int Id_Ingredient { get; set; }

        public string IngredientInfo
        {
            get
            {
                return $"{Id_Ingredient}";
            }
        }

    }
}
