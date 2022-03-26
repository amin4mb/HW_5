namespace OperatorOvlApplication;

public class person
{
    public int  ID { get; set; }
    public string Name { get; set; }    
    public int Age { get; set; }    
    public string Nasionalnumber { get; set; }


    public static bool operator ==(person x, person y)
    {
        bool status = false;
        try
        {
            if (x.Nasionalnumber == y.Nasionalnumber )
            {
                status = true;
            }

        }
        catch
        {
            status = true;
        }


        return status;
    }


    public static bool operator !=(person x, person y)
    {
        bool status = false;

        if (x.Nasionalnumber != y.Nasionalnumber)
        { status = true;
            return status; }
       return status;
   
    }

    public override string ToString()
    {
        return $"ID = {ID} Name= {Name} age = {Age} nasionalnumber = {Nasionalnumber}";
    }

}