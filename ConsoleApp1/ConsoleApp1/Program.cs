
class Program
{
    static void Nailend(char a, uint b)
    {

        for (int i = 0; i < b; i++)
        {
            Console.Write(a);

        }
    }


    static void Main(string[] args)
    {

        Console.WriteLine("Symbol: ");
        char symbol = Console.ReadKey().KeyChar;

        Console.WriteLine("\nNumber: ");
        uint Number = uint.Parse(Console.ReadLine());

        Nailend(symbol, Number);
    }



}











    

