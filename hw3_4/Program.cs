//task 3
class Convertor 
{
    private decimal _eurCurs;
    private decimal _dolCurs;

    public Convertor(decimal eurCurs, decimal dolCurs)
    {
        _eurCurs = eurCurs;
        _dolCurs = dolCurs;
    }   

    public decimal toEur(decimal grn)
    {
        return grn / _eurCurs;
    }
    public decimal toDol(decimal grn)
    {
        return grn / _dolCurs;
    }
}

class Program
{
    private static void Main(string[] args)
    {
        decimal eurCurs;
        decimal dolCurs;
        decimal yourGrn;
        decimal res;
        try
        {
            Console.WriteLine("Enter eur curs: ");
            eurCurs = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter dol curs: ");
            dolCurs = Convert.ToDecimal(Console.ReadLine());
        }
        catch (FormatException)
        {
            eurCurs = 36;
            dolCurs = 36;
            Console.WriteLine("Error");
        }

        Convertor convertor = new Convertor(eurCurs, dolCurs);

        Console.WriteLine("Enter your grn: ");
        try
        {
            yourGrn = Convert.ToDecimal(Console.ReadLine());
            res = convertor.toDol(yourGrn);
            Console.WriteLine("Dolar: " + res);
            res = convertor.toEur(yourGrn);
            Console.WriteLine("Euro: " + res);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error");
        }       
        Console.ReadLine();
    }
}