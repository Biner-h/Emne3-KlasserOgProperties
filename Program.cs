using System.Drawing;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        ConsoleColor black = ConsoleColor.Black;
        ConsoleColor blue = ConsoleColor.Blue;
        ConsoleColor red = ConsoleColor.Red;
        ConsoleColor darkmagenta = ConsoleColor.DarkMagenta;
        ConsoleColor yellow = ConsoleColor.Yellow;
        ConsoleColor white = ConsoleColor.White;
        
        var Name = pokeInfo(darkmagenta, black, 25, 10, "Hva heter pokemonen?");
        Console.WriteLine();
        var Health = Convert.ToInt32(pokeInfo(yellow, red, 25, 13, $"Hvor mye liv har {Name}?"));
        Console.WriteLine();
        var Level = Convert.ToInt32(pokeInfo(blue, white, 25, 16, $"Hvor mye liv har {Name}?"));
        Console.WriteLine();

        var person = new Pokemon(Name, Health, Level);
        person.printInfo(25, 19);
    }

    public static string pokeInfo(ConsoleColor backColor, ConsoleColor textColor, int x, int y, string s)
    {
        Console.BackgroundColor = backColor;
        Console.ForegroundColor = textColor;
        Console.SetCursorPosition(x, y);
        Console.Write(s);
        Console.SetCursorPosition(x, y + 1);
        var poke = Console.ReadLine();
        Console.ResetColor();

        return poke;
    }
}
