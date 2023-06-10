using System.Linq;
namespace DesignPattern.Console.BuilderPattern
{
    public class PreparedAlcoholDrinkConcreteBuilder : IBuilder
    {
        private PreparedDrink _preparedDrink;

        public PreparedAlcoholDrinkConcreteBuilder()
        {
            _preparedDrink = new PreparedDrink();
        }

        public void AddIngredients(string ingredients) =>
            _preparedDrink.Ingredients.Add(ingredients);

        public void Mix()
        {
            string ingredients = _preparedDrink.Ingredients.Aggregate((i, j) => $"{i}, {j}");
            _preparedDrink.Result = $"Bebida preparada con {_preparedDrink.Alcohol} de alcohol "
                + $"con los siguientes ingredientes: {ingredients}";
        }

        public void Reset() => _preparedDrink = new PreparedDrink();

        public void Rest(int time)
        {
            Thread.Sleep(time);
        }

        public void SetAlcohol(decimal alcohol)
        {
            _preparedDrink.Alcohol = alcohol;
        }

        public void SetMilk(int milk)
        {
            _preparedDrink.Milk = milk;
        }

        public void SetWater(int water)
        {
            _preparedDrink.Water = water;
        }

        public PreparedDrink GetPreparedDrink() => _preparedDrink;
    }
}
