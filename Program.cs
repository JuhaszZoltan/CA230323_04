using CA230323_04;
using System.Text;

List<Kategoria> kategoriak = new();
using StreamReader sr = new(@"..\..\..\src\titanic.txt", Encoding.UTF8);
while(!sr.EndOfStream)
{
    kategoriak.Add(new Kategoria(sr.ReadLine()));
}

Console.WriteLine($"2. feladat: {kategoriak.Count} db");

int sum = 0;
foreach(var k in kategoriak)
{
    sum += k.UtasokSzama;
}
Console.WriteLine($"3. feladat: {sum} fő");

Console.Write("4. feladat: Kulcszó: ");
string kulcsszo = Console.ReadLine();
bool vanTalalat = false;
int i = 0;
while(i < kategoriak.Count && !kategoriak[i].Nev.Contains(kulcsszo))
{
    i++;
}
if (i < kategoriak.Count)
{
    vanTalalat = true;
    Console.WriteLine("\tVan találat!");
}
else
{
    Console.WriteLine("\tNincs találat!");
}

if (vanTalalat)
{
    Console.WriteLine("5. feladat:");
    foreach (var k in kategoriak)
    {
        if (k.Nev.Contains(kulcsszo))
        {
            Console.WriteLine($"\t{k.Nev} {k.UtasokSzama} fő");
        }          
    }
}

List<string> meghaladta = new();
foreach (var k in kategoriak)
{
    if (k.Eltuntek > k.UtasokSzama * .6F)
    {
        meghaladta.Add(k.Nev);
    }
}
Console.WriteLine("6. feladat:");
foreach (var s in meghaladta)
{
    Console.WriteLine($"\t{s}");
}

int maxi = 0;
for (int j = 1; j < kategoriak.Count; j++)
{
    if (kategoriak[j].Tulelok > kategoriak[maxi].Tulelok)
    {
        maxi = j;
    }
}
Console.WriteLine($"7. feladat: {kategoriak[maxi].Nev}");