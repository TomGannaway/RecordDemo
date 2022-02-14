// See https://aka.ms/new-console-template for more information
using DotNetSixCSharpTen;

Console.WriteLine("Hello, World!");


var p = new Package()
{
    To = "Jeff",
    RequiredBy = DateTime.Now.AddDays(2)
};


ShippingService shippingService = new();

// "Command" (Action)
shippingService.ShipPackage(p);

var newPackage = shippingService.DeferFor(5, p);

Console.WriteLine($"the origianal package {p.RequiredBy} {p.To} to {p.To}");

Console.WriteLine($"The New Package is {newPackage.RequiredBy} to { p.To}");


var cleanOffice = new TodoItem(1, "Clean The Office", DateTime.Now, false);

Console.WriteLine(cleanOffice.Description);


var doneCleaningOffice = cleanOffice with { completed = true };

Console.WriteLine(cleanOffice);

Console.WriteLine(doneCleaningOffice);

var n = shippingService.FormatName("Luke", "Skywalker");
Console.WriteLine(n.formattedName);
Console.WriteLine(new String('_', n.length));
