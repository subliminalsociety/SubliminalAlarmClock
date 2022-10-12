namespace Console_AlarmClock;

static class Util {
    public static void Print(string s) {
        Console.WriteLine(s);
    }

    public static string Input() {
        return Console.ReadLine() ?? string.Empty;
    }

    public static void Div() {
        Print("");
        Console.ForegroundColor = ConsoleColor.Gray;
        Print("----------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Print("");
    }

    public static void Clear() {
        Console.Clear();
    }
}