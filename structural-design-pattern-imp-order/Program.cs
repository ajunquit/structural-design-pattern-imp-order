// See https://aka.ms/new-console-template for more information
using structural_design_pattern_imp_order;
using System.Data;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");

IOrder order = new Order();

order = new GreetingCardDecorator(order);
order = new GiftWrappingDecorator(order);

Console.WriteLine(order.GetDescription());
Console.WriteLine(order.GetTotalPrice());
