namespace Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            for (char i = startLetter; i <= endLetter; i++) {
            Console.WriteLine(i + " ");
            }
        }
    }
}