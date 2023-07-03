//Expr1. Как поменять местами значения двух переменных? Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?
//Ответ: можно. Для числовых одинаковых переменных с точным значением можно использовать математические операции.
//Также можно использовать побитовое перемещение XOR для целочисленных значений


internal class Program
{
    public static void Main(string[] args)
    {
        /*
        var variable1 = Console.ReadLine();
        var variable2 = Console.ReadLine();
        Swap1(ref variable2, ref variable1);
        Console.WriteLine($"variable1 = {variable1}, variable2 = {variable2}", variable1,variable2);
        */
        Console.WriteLine("Ввод целых чисел");
        int variable3 = Convert.ToInt32(Console.ReadLine());
        int variable4 = Convert.ToInt32(Console.ReadLine());
        XorSwap(ref variable3, ref variable4);
        Console.WriteLine($"variable3 = {variable3}, variable4 = {variable4}", variable3, variable4);
    }

    // первый способ - через третью переменную
    public static void Swap1<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
        
    }
    static void XorSwap(ref int a, ref int b)
    {
        a ^= b; 
        b ^= a;
        a ^= b;
    }
}