Console.WriteLine("Enter coordinate x of dot A:");
var aX = double.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot A:");
var aY = double.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate x of dot B:");
var bX = double.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot B:");
var bY = double.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate x of dot C:");
var cX = double.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot C:");
var cY = double.Parse(Console.ReadLine());

var abSideSquared = DistanceSquared(aX, aY, bX, bY);
var bcSideSquared = DistanceSquared(bX, bY, cX, cY);
var caSideSquared = DistanceSquared(cX, cY, aX, aY);

var abSide = Math.Sqrt(abSideSquared);
var bcSide = Math.Sqrt(bcSideSquared);
var caSide = Math.Sqrt(caSideSquared);

Console.WriteLine($"Length of AB is: {abSide}");
Console.WriteLine($"Length of BC is: {bcSide}");
Console.WriteLine($"Length of AC is: {caSide}");

var isEquilateral = DoubleEqual(abSideSquared, bcSideSquared) && DoubleEqual(bcSideSquared, caSideSquared);
Console.WriteLine($"Triangle is{(isEquilateral ? "" : " NOT")} Equilateral");


var perimeter = abSide + bcSide + caSide;
Console.WriteLine($"Perimeter: {perimeter}");

Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");
for (var i = 0; i < perimeter; i += 2) { Console.WriteLine(i); }


