using GenericClass;

internal class Program
{
    private static void Main(string[] args)
    {
        GenericClass<int> gn = new GenericClass<int> ();
        gn.AddList(2);
        gn.AddList(10);
        gn.AddList(4);
        gn.AddList (5);
        var result=gn.showdata(2);
        Console.WriteLine(result);
        result= gn.showdata(3);
        Console.WriteLine(result);
        var ordered = gn.getSortList();
            foreach(var i in ordered)
        {
            Console.WriteLine(i);
        }
    }
}