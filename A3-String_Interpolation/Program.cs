namespace A3_String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            Console.WriteLine($"{date,40:MMMM d yyyy}");
            Console.WriteLine($"{date:yyyy.MM.dd}");
            Console.WriteLine($"Day {date:d} of {date:MMMM, yyyy}");
            Console.WriteLine($"Year: {date:yyyy}, Month: {date:MM}, Day: {date:dd}");
            Console.WriteLine($"{date,10:dddd}");
            Console.WriteLine($"{date,10:hh:mm tt}{date,10:dddd}");
            Console.WriteLine($"h:{date:hh}, m:{date:mm}, s:{date:ss}");
            Console.WriteLine($"{date:yyyy.MM.dd.hh.mm.ss}");

            var pi = Math.PI;
            Console.WriteLine($"{pi:C}");
            Console.WriteLine($"{pi,10:n3}");
        }
    }
}