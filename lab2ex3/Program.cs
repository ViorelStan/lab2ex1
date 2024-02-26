/*
 * Scrieti un program care va afisa suma cifrelor unui numar n, n fiind citit de la tastatura
*/

Console.WriteLine("Se citeste de la tastatura un numar n");
int numar = int.Parse(Console.ReadLine());

int suma = 0;

while (numar > 0)
{
    int r = numar % 10;
    suma = suma + r;
    numar = numar / 10;
}
Console.WriteLine("Suma cifrelor numarului citit de la tastatura este: "+ suma);
