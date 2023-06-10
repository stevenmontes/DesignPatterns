using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Console.BuilderPattern
{
    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public void PrepareMargarita()
        {
            _builder.Reset();
            _builder.AddIngredients("Tequila");
            _builder.SetAlcohol(10);
            _builder.Mix();
            _builder.Rest(100);
        }

        public void PreparePinaColada()
        {
            _builder.Reset();
            _builder.AddIngredients("Tequila");
            _builder.AddIngredients("Tequila");
            _builder.AddIngredients("Tequila");
            _builder.AddIngredients("Tequila");
            _builder.AddIngredients("Tequila");
            _builder.AddIngredients("Tequila");
            _builder.AddIngredients("Tequila");
            _builder.AddIngredients("Tequila");
            _builder.SetAlcohol(10);
            _builder.Mix();
            _builder.Rest(100);
        }
    }
}
