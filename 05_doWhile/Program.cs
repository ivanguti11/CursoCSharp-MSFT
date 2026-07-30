/*Random numero = new Random();
int tirada = 0;

do
{
    tirada = numero.Next(1,11);
    Console.WriteLine(tirada);

}while (tirada >=4);

Random random = new Random();
int current = random.Next(1, 11);


do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);


int vidaHeroe = 10;
int vidaMonster = 10;
Random tirada = new Random();
int ataque = 0;

do
{
ataque = tirada.Next(1,11);
 vidaMonster -= ataque;
 if(vidaMonster > 0)
 Console.WriteLine($"El Monstruo sufrió {ataque} de daño, ahora tiene {vidaMonster} de vida");
 else{
 Console.WriteLine($"El Monstruo sufrió {ataque} de daño, el Monstruo murió con {vidaMonster} de vida\n El Héroe gana");
 continue;
 }
 ataque = tirada.Next(1,11);
 vidaHeroe -= ataque;
 if(vidaHeroe > 0)
 Console.WriteLine($"El Héroe sufrió {ataque} de daño, ahora tiene {vidaHeroe} de vida");
 else {
 Console.WriteLine($"El Héroe sufrió {ataque} de daño, el Héroe murió con {vidaHeroe} de vida\n El Monstruo gana");
 continue;
 }
}while((vidaHeroe > 0) && (vidaMonster > 0));


string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);

// ejercicio 1
bool entrada = false;
string? usuario;

Console.WriteLine("Ingresa un número entre el 5 y 10");

while (entrada == false)
{
    usuario = Console.ReadLine();
    if (int.TryParse(usuario, out int entero))
        if ((entero > 4)&& (entero <11)){
            Console.WriteLine($"El numero que ingresaste ({entero}), es válido!");
            entrada = true;}
        else 
        Console.WriteLine($"El numero que ingresaste: {entero}, no es valido ");
    else
    Console.WriteLine($"Debes de ingresar un numero, {usuario}, no es un numero"); 
}
*/
// ejercicio 2

string? rango; 
bool entrada = false;

Console.WriteLine("Que usuario eres: Administrador, Director o Usuario");

do
{
    rango = Console.ReadLine();
    if (rango != null)
    rango = rango.ToLower().Trim();
        if(rango == "administrador" ||rango == "director" || rango == "usuario")
        entrada = true;
    else
    Console.WriteLine($"El rol que ingresaste {rango} no es valido, Ingresa tu rol (Administrador, Director o Usuario)");

}while(entrada == false);

Console.WriteLine($"Tu valor de entrada {rango}, ha sido aceptado");

/*
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}

*/