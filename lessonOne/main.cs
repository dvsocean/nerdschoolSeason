Console.WriteLine("----LESSON ONE-----");

string strVar = "Hello";
var StrVar = "Hello";
var intVar = 98;
var boolVar = false;

Console.WriteLine(boolVar);

Console.WriteLine("---- Variables & Primitive Types -------");

int[] snacks = {3, 4, 55};
string[] stringSnacks = {"stringOne", "stringTwo"};


Console.WriteLine("List");
 List<string> bag = new List<string>();
 bag.Add("Item One");

 Console.WriteLine("No interpolation");
 Console.WriteLine(intVar);

 Console.WriteLine($"With interpolation {intVar}");

 Console.WriteLine("---- STORE APP ------");
var taxRate = 10.5;
var storeItemCost = 50;
List<string> cart = new List<string>();
cart.Add("ItemOne");
cart.Add("ItemTwo");
cart.Add("ItemThree");

var storeName = "NerdSchoolApp";
var sum = cart.Count * storeItemCost;

var totalTax = sum * taxRate;
var grandTotal = sum + totalTax;

Console.WriteLine($"Welcome to {storeName}. You have {cart.Count} items in your bag");
Console.WriteLine($"Your total is: {grandTotal}");




 
 
 







