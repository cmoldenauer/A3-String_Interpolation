namespace A3_String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            Console.WriteLine($"{date:MMMM d yyyy}");
            Console.WriteLine($"{date:yyyy.MM.dd}");
        }
    }
}