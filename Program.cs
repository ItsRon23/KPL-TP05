// See https://aka.ms/new-console-template for more 

internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser<string>("Aaron Joseph");
        DataGeneric<int> ObjData = new DataGeneric<int>(1302223083);
        ObjData.PrintData();
    }
}


class DataGeneric<T>
{
    private T data;

    public DataGeneric(T inputData)
    {
        data = inputData;
    }

    public void PrintData()
    {
        Console.WriteLine("Data: " + data);
    }
}


class HaloGeneric
{
    public static void SapaUser<T>(T X)
    {
        Console.WriteLine($"Halo user {X}", X);
    }
}

