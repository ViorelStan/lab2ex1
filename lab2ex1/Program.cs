/*
 *Scrieti un program care va calcula valoarea urmatoarei functii pentru x citit de la tastatura 
 * 7x2, daca x apartine intervalului (-infinit, -2]
 * 4x - 5, daca x apartine intervalului (-2, 1/2]
 * 14x - 7, daca x apartine (1/2, infinit)
*/

Console.WriteLine("Se citeste de la tastatura numarul x");
float x = float.Parse(Console.ReadLine());

float functie = 0;

if (x < -2)
{
    functie = 7 * (x * 2);
    Console.WriteLine("Rezultatul calcului este: " + functie);
}
else if (x >= -2 && x < 1 / 2)
{
    functie = (4 * x) - 5;
    Console.WriteLine("Rezultatul calculului este:" + functie);
}
else
{
    functie = (14 * x) - 7;
    Console.WriteLine("Rezultatul calculului este:" + functie);
}