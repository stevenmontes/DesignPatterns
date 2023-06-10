using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPattern
{
    public class PreparedDrink
    {
        public List<string> Ingredients { get; set; } = new List<string>();
        public int Milk { get; set; }
        public int Water { get; set; }
        public decimal Alcohol { get; set; }

        public string? Result { get; set; }

        public PreparedDrink(List<string> ingredients, int milk, int water, decimal alcohol, string? result)
        {
            Ingredients = ingredients;
            Milk = milk;
            Water = water;
            Alcohol = alcohol;
            Result = result;
        }
    }
}
