using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siesta2
{
    public class Ingredient
    {
        public int Id_Ingredient { get; set; }
        public string Name { get; set; }
        public string IngredientInfo
        {
            get
            {
                return $"{Name}";
            }
        }
    }
}
