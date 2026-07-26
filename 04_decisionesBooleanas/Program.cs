/* Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower())

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");


Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);


string pangram = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(pangram.Contains("fox"));
//Console.WriteLine(pangram.Contains("cow"));
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False

//Console.WriteLine(pangram.Contains("fox") == false);
//Console.WriteLine(!pangram.Contains("fox"));

//int saleAmount = 1001;
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {discount}");

int saleAmount = 1001;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");


Random game = new Random();

int roll = game.Next(0,2);
Console.WriteLine($"El restulado es {(roll != 1? "Cruz": "Cara")}, Esto salio: {roll}") ;



using Microsoft.Win32.SafeHandles;

int nivel = 55;
string permiso = nivel >= 20 ? "Admin|Manager" : "SinPrivilegios";

if(permiso.Contains("Admin"))
{
    if (nivel > 55)
    Console.WriteLine("Bienvenido usuario Super Admin");
    else if (nivel <= 55 && nivel >20)
    Console.WriteLine("Bienvenido, usuario Admin");
    else if (nivel == 20)
    Console.WriteLine("Contacta a un Admin para tus accesos");
}
else if (permiso.Contains("SinPrivilegios"))
Console.WriteLine("No tienes suficientes privilegios");

// Hasta aqui termina la clase de operador ternario */

/* bool flag = true;
int value = 0;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");
*/

// Code sample 1
/*
bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");

// Code sample 2
int value;

if (true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");
*/

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
    }
if (found) 
    Console.WriteLine("Set contains 42");
Console.WriteLine($"Total: {total}");