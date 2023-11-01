using BA.CarWashingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Entities
{
    public class MaterialWashingRecipe:BaseEntity
    {
        public int WashingRecipeId { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }
        public WashingRecipe WashingRecipe { get; set; }
    }
}
