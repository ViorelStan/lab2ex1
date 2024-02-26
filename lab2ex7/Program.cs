/*
* Se citesc trei numere de la tastatura, x, y, z.
* Scrieti un program care va afisa cele 3 valori in ordine descrescatoare
*/

using System.ComponentModel.Design;

Console.WriteLine("Introduceti valoarea pentru x");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti valoarea pentru y");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti valoarea pentru z");
int z = int.Parse(Console.ReadLine());

if ((x > y) && (x > z))
    if (y > z)
    {
        Console.WriteLine("Ordonare descrescatoare: " + x + ";" + y + ";" + z);
    }
    else
    {
        Console.WriteLine("Ordonare descrescatoare: " + x + ";" + z + ";" + y);
    }
else if ((y > x) && (y > z))
{
    if (x > z)
        Console.WriteLine("Ordonare descrescatoare: " + y + ";" + x + ";" + z);
    else
        Console.WriteLine("Ordonare descrescatoare: " + y + ";" + z + ";" + x);
}
else if ((z > x) && (z > y))
    if (x > y)
    {
        Console.WriteLine("Ordonare descrescatoare: " + z + ";" + x + ";" + y);
    }
    else
    {
        Console.WriteLine("Ordonare descrescatoare: " + z + ";" + y + ";" + x);
    }