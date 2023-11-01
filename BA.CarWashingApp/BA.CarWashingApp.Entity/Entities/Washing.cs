using BA.CarWashingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Entities
{
    public class Washing:BaseEntity
    {
        public Washing()
        {
            WashingTypeWashings = new();
        }
        public int RemainingTime { get; set; } //Dakika
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public int WashingRecipeId { get; set; }
        public WashingRecipe WashingRecipe { get; set; }
        public List<WashingTypeWashing> WashingTypeWashings { get; set; }
      
        public Vehicle Vehicle { get; set; }
        public Employee Employee { get; set; }
        
    }
}
