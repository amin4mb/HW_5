
using OperatorOvlApplication;

List<person> list = new List<person>();

list.Add(new person { ID = 1, Name = "amin" ,Age = 28, Nasionalnumber = "215666565" }); 
list.Add(new person { ID = 2, Name = "ali", Age = 14, Nasionalnumber = "5656523232"});
list.Add(new person { ID = 3, Name = "saed", Age = 30, Nasionalnumber = "757575757"});
list.Add(new person { ID = 4, Name = "mohamad", Age = 18, Nasionalnumber = "5656523232"});

CRUD(list);

void CRUD(List<person> lis)
{
    Console.Clear();
    Console.WriteLine("\n\n       MAIN MENU");
    Console.WriteLine("\nWhat would you like to do?");
    Console.WriteLine("\nType 0 to Close Application.");
    Console.WriteLine("Type 1 to View All Records.");
    Console.WriteLine("Type 2 to Insert Records.");
    Console.WriteLine("Type 3 to Delete Records.");
    Console.WriteLine("Type 4 to Update Records.");
    Console.WriteLine("Type 5 to compare Records.");


    var input = Console.ReadKey();

    switch (input.Key)
    {
        case ConsoleKey.NumPad0:
            break;
        case ConsoleKey.NumPad1:
            Console.Clear();
            Console.WriteLine("\n\n       VIEW MENU");
            foreach (var item in lis)
            {
                Console.WriteLine($"\n{item.ToString()}");
            }
            Console.WriteLine("\n\nenter key to contenu");
            Console.ReadKey();
            CRUD(lis);
            break;
        case ConsoleKey.NumPad2:
            Console.Clear();
            Console.WriteLine("\n\n       INSERT MENU");
            insert(lis);
            Console.WriteLine("1 row efectiv");
            Console.WriteLine("enter key to contenu");
            Console.ReadKey();
            CRUD(lis);
            break;
        case ConsoleKey.NumPad3:
            Console.Clear();
            Console.WriteLine("\n\n      DELETE MENU");
            delete(lis);
            Console.WriteLine("\n\ndeleted");
            Console.WriteLine("\n\nenter key to contenu");
            Console.ReadKey();
            CRUD(lis);
            break;
        case ConsoleKey.NumPad4:
            Console.Clear();
            Console.WriteLine("\n\n      update MENU");
            //delete(lis);
            //insert(lis);
            //lis = lis.OrderBy(x => x.ID).ToList();
            update(lis);
            Console.WriteLine("enter key to contenu");
            Console.ReadKey();
            CRUD(lis);
            break;
        case ConsoleKey.NumPad5:
            Console.Clear();
            Console.WriteLine("\n\n      COMPARE MENU");
            Console.WriteLine("enter first id  record ");
            var id1 =Convert.ToInt32( Console.ReadLine());
            person? p1 =lis.Find(p => p.ID == id1);

            Console.WriteLine("enter second id  record ");
            var id2 = Convert.ToInt32(Console.ReadLine());
            person? p2 = lis.Find(p => p.ID == id2);
            //if (p1 == null)
            //{
            //    Console.WriteLine("not found this ID");
            //    Console.ReadKey();
            //    CRUD(lis);
            //}
            //if (p2 == null)
            //{
            //    Console.WriteLine("not found this ID");
            //    Console.ReadKey();
            //    CRUD(lis);
            //}
            Console.WriteLine(p1 == p2);
            Console.WriteLine("enter key to contenu");
            Console.ReadKey();
            CRUD(lis);
            break;
        default:
            Console.WriteLine("you enter dont valid key ");
            Console.WriteLine("\n\nenter key to contenu");
            Console.ReadKey();
            CRUD(lis);
            break;
    }


}

void insert(List<person> lis)
{

    Console.WriteLine($"\n\nenter new ID ");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"enter name ");
    string name = Console.ReadLine().ToLower();
    Console.WriteLine($"AGE");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"enter nasionalnumber ");
    string nasionalnumber = Console.ReadLine().ToLower();
    person newperson = new person {ID = id , Name = name, Age = age, Nasionalnumber = nasionalnumber };
    lis.Add(newperson);
}

void delete(List<person> lis)
{
    Console.WriteLine("enter id ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (lis.Any(p => p.ID == x))
    {
        lis.RemoveAll(p => p.ID == x);
    }
    else
    {
        Console.WriteLine("this ID not");
        Console.WriteLine("\n\nenter key to contenu");
        Console.ReadKey();
        delete(lis);
    }

}


void update(List<person> lis )
{
    Console.WriteLine("enter id ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (lis.Any(p => p.ID == x))
    {
        Console.WriteLine($"enter name ");
        string name = Console.ReadLine().ToLower();
        Console.WriteLine($"AGE");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"enter nasionalnumber ");
        string nasionalnumber = Console.ReadLine().ToLower();

        person onepesone = lis.Where(p => p.ID == x).ToList()[0];

        onepesone.Age = age;
        onepesone.Name = name;
        onepesone.Nasionalnumber = nasionalnumber;
    }
    else
    {
        Console.WriteLine("this ID not");
        Console.WriteLine("\n\nenter key to contenu");
        Console.ReadKey();
        update(lis);
    }

}
