using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Pokemon
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }

    public Pokemon(string name, int health, int level)
    {
        Name = name;
        Health = health;
        Level = level;
    }

    public void printInfo(int x, int y)
    {
        ConsoleColor cyan = ConsoleColor.Cyan;
        ConsoleColor black = ConsoleColor.Black;
        ConsoleColor white = ConsoleColor.White;
        ConsoleColor red = ConsoleColor.Red;
        
        Console.BackgroundColor = cyan;
        Console.ForegroundColor = black;
        Console.SetCursorPosition(x, y);
        Console.WriteLine($"Pokemon name: {Name}");
        Console.ResetColor();

        Console.BackgroundColor = white;
        Console.ForegroundColor = red;
        Console.SetCursorPosition(x, y + 1);
        Console.WriteLine($"Pokemon health: {Health}hp");
        Console.ResetColor();

        Console.BackgroundColor = red;
        Console.ForegroundColor = black;
        Console.SetCursorPosition(x, y + 2);
        Console.WriteLine($"Pokemon level: {Level}");
        Console.ResetColor();
    }
}