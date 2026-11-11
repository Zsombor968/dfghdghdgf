List<Adat> data = [];
#region
const string FilePath = "..\\..\\..\\data\\videogames.csv";
using StreamReader sr = new(FilePath);
_ = sr.ReadLine();
while (!sr.EndOfStream)
{
    var tmp = sr.ReadLine().Split(",");
    data.Add(new()
    {
        Cim = tmp[0],
        Mufaj = tmp[1],
        Kiadas = Convert.ToDateTime(tmp[2]),
        Aktiv = tmp[3],
        Ertekeles = int.Parse(tmp[4]),
    });
}
#endregion
//1
var Rating = data.Count(g  => g.Ertekeles > 4.5);
Console.WriteLine("1.feladata 4.5 felet:" +  Rating);
//2
var legtobbJatek = data.MaxBy(g => g.Aktiv);
Console.WriteLine("2.feladat: " +  legtobbJatek.Cim);
//3
var Jatek2020elott = data.Any(g => g.Kiadas < new DateTime(2020, 1, 1));
Console.WriteLine("3.feladat" + Jatek2020elott);
//4
var Atlag = data.Average(g => g.Ertekeles);
Console.WriteLine("4feladat" + Atlag); 
//5
var cyber = data.FirstOrDefault(g => g.Cim == "Cyber City 2077");
Console.WriteLine("5.feladat: " + cyber);
//6
var keres = data.Where(g => g.Mufaj == "RPG").OrderByDescending(g => g.Kiadas);
//7
var top3jatek = data.OrderByDescending(g => g.Ertekeles);
