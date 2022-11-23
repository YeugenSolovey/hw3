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
       
        bool flag = true;

        //euro
        try {
            do
            {
                Console.WriteLine("Enter euro curs: ");
                eurCurs = Convert.ToDecimal(Console.ReadLine());
                if (eurCurs <= 0)
                {
                    Console.WriteLine("Error");
                    flag = true;
                }
                else flag = false;
            } while (flag);
        }
        catch(FormatException)
        {
            do
            {
                Console.WriteLine("Enter euro curs: ");
                eurCurs = Convert.ToDecimal(Console.ReadLine());
                if (eurCurs <= 0)
                {
                    Console.WriteLine("Error");
                    flag = true;
                }
                else flag = false;
            } while (flag);
        }
        //dolar
        try
        {
            do
            {
                Console.WriteLine("Enter dolar curs: ");
                dolCurs = Convert.ToDecimal(Console.ReadLine());
                if (dolCurs <= 0)
                {
                    Console.WriteLine("Error");
                    flag = true;
                }
                else flag = false;
            } while (flag);
        }
        catch(FormatException)
        {
            do
            {
                Console.WriteLine("Enter dolar curs: ");
                dolCurs = Convert.ToDecimal(Console.ReadLine());
                if (dolCurs <= 0)
                {
                    Console.WriteLine("Error");
                    flag = true;
                }
                else flag = false;
            } while (flag);
        }
        

        Convertor convertor = new Convertor(eurCurs, dolCurs);
        //grn
        try
        {
            do
            {
                Console.WriteLine("Enter grn curs: ");
                yourGrn = Convert.ToDecimal(Console.ReadLine());
                if (yourGrn <= 0)
                {
                    Console.WriteLine("Error");
                    flag = true;
                }
                else flag = false;
            } while (flag);
        }
        catch (FormatException)
        {
            do
            {
                Console.WriteLine("Enter your grn: ");
                yourGrn = Convert.ToDecimal(Console.ReadLine());
                if (yourGrn <= 0)
                {
                    Console.WriteLine("Error");
                    flag = true;
                }
                else flag = false;
            } while (flag);
        }

        res = convertor.toDol(yourGrn);
        Console.WriteLine("Dolar: " + res);
        res = convertor.toEur(yourGrn);
        Console.WriteLine("Euro: " + res);
               
        Console.ReadLine();
    }
}