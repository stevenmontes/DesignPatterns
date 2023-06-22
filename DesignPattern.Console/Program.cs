// See https://aka.ms/new-console-template for more information
using DesignPattern.Console.StatePattern;

var customerContext = new CustomerContext();
Console.WriteLine(customerContext.State);
customerContext.Request(100);
Console.WriteLine(customerContext.State);

customerContext.Request(50);
Console.WriteLine(customerContext.State);

customerContext.Request(50); 
Console.WriteLine(customerContext.State);