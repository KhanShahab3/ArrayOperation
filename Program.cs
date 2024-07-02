internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[5];
        Console.WriteLine("{0}{1,8}", "Index", "Value");
        for(int counter=0; counter<array.Length; counter++)
        {
            Console.WriteLine("{0,5}{1,8}", counter, array[counter]);
        }
    }
}