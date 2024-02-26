/*
 * Scrieti un program care va determina daca un numar este sau nu palindrom
*/

Console.WriteLine("Va rugam introduceti un numar din mai multe cifre");
int n = int.Parse(Console.ReadLine());


int r, sum = 0, temp;
temp = n;
while (n > 0)
{
    r = n % 10;
    sum = (sum * 10) + r;
    n = n / 10;
    //Console.WriteLine(r + " " + sum + " " + n);
}
if (temp == sum)
    Console.Write("Numarul este palindrom");
else
    Console.Write("Numarul nu este palindrom");