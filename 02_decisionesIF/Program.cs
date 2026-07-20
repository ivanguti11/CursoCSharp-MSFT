/*Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);


int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
    }
        else
        {
         Console.WriteLine("You rolled doubles! +2 bonus to total!");
         total += 2;
        }
    Console.WriteLine($"Your total including the bonus: {total}");
}       
if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}
*/

Random random = new Random();
int diasExpiracion = random.Next(12);
int porcentajeDescuento = 0;

Console.WriteLine(diasExpiracion);
if(diasExpiracion <= 10 && diasExpiracion > 5)
{
    Console.WriteLine("Tu suscripción se vencerá pronto, renuevala ya!");
}
else if (diasExpiracion <= 5 && diasExpiracion >1)
{
    porcentajeDescuento = 10;
    Console.WriteLine(@$"Tu suscripción termina en {diasExpiracion} días.
Renueve ahora y obtén un {porcentajeDescuento}%!");
}
else if (diasExpiracion == 1)
{
    Console.WriteLine("Tu suscripción vence en 1 día, renueva ahora y gana un 20% de descuento");
}
else if (diasExpiracion == 0)
{
    Console.WriteLine("Tu suscripción se expiró");
}
else
{
    Console.WriteLine("Nothing");
    }