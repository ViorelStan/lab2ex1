/*
 * Scrieti un program care va determina daca un numar negativ citit de la tastatura
 * este divizil cu 2 si nu este divizibil cu 6 
*/


Console.WriteLine("Cititi un numar de la tastaura:");
float x = float.Parse(Console.ReadLine());

if (x >= 0)
{
    Console.WriteLine("Numarul nu este negativ!");
}
else if (x % 2 == 0 && x % 6 == 0)
{
    Console.WriteLine("Numarul este divizil cu 2 si 6");
}
else
{
    Console.WriteLine("Numarul nu este deivizil cu 2 si 6");
}
