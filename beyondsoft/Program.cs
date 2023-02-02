// See https://aka.ms/new-console-template for more information
using beyondsoft;

Console.WriteLine("Hello, World! Please input the string to validate");
string input = Console.ReadLine();

var checker = new BraceChecker();

var result = checker.isValid(input);

Console.WriteLine(result);