using BA.CarWashingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Entities
{
    public class Material:BaseEntity
    {
        public Material()
        {
            MaterialWashingRecipes = new();
        }
        public string Name { get; set; }
        public decimal Stock { get; set; }
        public decimal MinStock { get; set; }
        public List<MaterialWashingRecipe> MaterialWashingRecipes { get; set; }
    }
}
