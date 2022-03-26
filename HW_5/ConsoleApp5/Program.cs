var x = File.ReadAllLines("3.txt");

List<person> persons = new List<person>();

for (int i = 0; i < x.Length; i++)
{
    var lis = x[i].Split("\t").ToList();
    person oneperson = new person(Convert.ToInt32(lis[0]), lis[1]) { Age = int.Parse(lis[2]), brithday = modifidatetime(lis[3]), Addres = lis[4], Nasionalnumber = long.Parse(lis[5]) };
    persons.Add(oneperson);
}
DateTime modifidatetime(string x)
{
    var j = x.Split("/");
    var n = j[0];
    j[0] = j[1];
    j[1] = n;
    string k = j[0] + "/" + j[1] + "/" + j[2];
    DateTime date = DateTime.Parse(k);
    return date.Date;
}


var a = persons.Where(p => p.Age > 20).OrderBy(p => p.Name).ToList();

var b = persons.Where(p => p.brithday < DateTime.Parse("01/01/1999")).ToList();


var cc = persons.GroupBy(p => p.brithday).Where(g => g.Count() > 1).ToDictionary(x => x.Key, x => x.ToList());



var d = persons.OrderBy(p => p.ID).ToList()[3];

var e = persons.OrderBy(p => p.ID).ToList().GetRange(50, 30);

var f = persons.Where(t => t.Age == persons.Max(p => p.Age)).ToList();


var g = persons.GroupBy(p => p.Nasionalnumber).Where(g => g.Count() > 1).ToDictionary(x => x.Key, x => x.Count());
Console.WriteLine("[Value, Count]: " + String.Join("-", g));


var h = persons.Where(P => P.Addres.Contains("tehran")).ToList();

var ii = persons.Where(P => P.Addres.Contains("tehran")).GroupBy(p => p.Name).Where(g => g.Count() > 1).ToDictionary(x => x.Key, x => x.Count());
Console.WriteLine("[Value, Count]: " + String.Join("-", ii));

var j = persons.Where(k => k.Nasionalnumber.ToString().Contains("123")).ToList();


var k = persons.Where(p => p.Age > 25).ToList();
Console.WriteLine("People who are older than 25 years  :");

foreach (var item in k)
{
    Console.WriteLine(item.ToString());
}






