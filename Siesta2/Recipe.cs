using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siesta2
{
    public class Recipe
    {
        public int Id_Recipe { get; set; }
        public string Name { get; set; }
        public int PreepTime { get; set; }
        public string Instruction { get; set; }
        public string FullInfo 
        {
            get 
            { 
                return $"{Name} {PreepTime}"; 
            }
        }
    }   
}
