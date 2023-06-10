// See https://aka.ms/new-console-template for more information
using DesignPattern.Console.BuilderPattern;

var builder = new PreparedAlcoholDrinkConcreteBuilder();
var director = new Director(builder);
director.PrepareMargarita();
var preparedDrink = builder.GetPreparedDrink();
Console.WriteLine(preparedDrink.Result);
