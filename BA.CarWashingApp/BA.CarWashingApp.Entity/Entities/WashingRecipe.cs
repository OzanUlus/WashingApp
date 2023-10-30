using BA.CarWashingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Entities
{
    public class WashingRecipe:BaseEntity
    {
        public WashingRecipe()
        {
            Washings = new();
            MaterialWashingRecipes = new();
        }
        public string MaterialName { get; set; }
        public decimal Amount { get; set; }
        public decimal PriceFactor { get; set; }
        public List<Washing> Washings { get; set; }
        public List<MaterialWashingRecipe> MaterialWashingRecipes { get; set; }
    }
}
