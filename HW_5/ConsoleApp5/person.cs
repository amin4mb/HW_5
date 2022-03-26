public class person
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime brithday { get; set; }
    public string Addres { get; set; }
    public long  Nasionalnumber { get; set; }
    public person(int id, string name)
    {
        ID = id;
        Name = name;
    }
    public override string ToString()
    {
        return $"nasionalnumber = {Nasionalnumber}  ---  addres {Addres}";
    }

}