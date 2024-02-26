/*
 * Scrieti un program care va afisa factorialul unui numar n, n fiind citit de la tastatura
*/

Console.WriteLine("Se citeste de la tastatura numarul n");
int numar = int.Parse(Console.ReadLine());
int factorial = 1;

for (int i = 1;  i <= numar; i++)
{
    factorial = factorial * i;
}
Console.WriteLine("Factorialul numarului " + numar + " este:" + factorial);