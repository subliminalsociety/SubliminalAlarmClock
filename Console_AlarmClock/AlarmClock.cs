using static Console_AlarmClock.Util;

namespace Console_AlarmClock;
public class AlarmClock {
    private static int int_hours;
    private static int int_minutes;
    private static int int_seconds;
    
    private static bool am_or_pm = true;
    
    private static bool isRunning = true;
    
    public AlarmClock() {
        Setup();
        Start();
        while (isRunning) {
            Update();
            System.Threading.Thread.Sleep(1000);
        }
    }

    private void Setup() {
        Console.Title = ("Subliminal Alarm Clock");
        Console.ForegroundColor = ConsoleColor.Green;
        
        Print("Subliminal Alarm Clock");
        Div();
    }
    private void Start() {
        Print("Is it AM or PM?");
        Console.Write(">> ");
        string string_am_or_pm = Input().ToLower();
        if (string_am_or_pm == "am") {
            am_or_pm = true;
        } else if (string_am_or_pm == "pm") {
            am_or_pm = false;
        }
        else {
            Print("Error. You entered incorrectly");
            return;
        }
        
        Div();
        Print("What time is in the HOURS place?");
        Console.Write(">> ");
        String string_hours = Input();
        int_hours = int.Parse(string_hours);
        if (int_hours < 1 || int_hours > 12) {
            Print("Error. You entered incorrectly");
            return;
        }

        Div();
        Print("What time is in the MINUTES place?");
        Console.Write(">> ");
        String string_minutes = Input();
        int_minutes = int.Parse(string_minutes);
        if (int_minutes < 1 && int_minutes > 59) {
            Print("Error. You entered incorrectly");
            return;
        }

        Div();
        Print("What time is in the SECONDS place?");
        Console.Write(">> ");
        String string_seconds = Input();
        int_seconds = int.Parse(string_seconds);
        if (int_seconds < 1 && int_seconds > 59) {
            Print("Error. You entered incorrectly");
            return;
        }
        Div();
    }

    private void Update() {
        int_seconds++;
            
        if (int_seconds > 59) {
            int_seconds = 0;
            int_minutes++;
        }
            
        if (int_minutes > 59) {
            int_minutes = 0;
            int_hours++;
        }
        if (int_hours > 11) {
            am_or_pm = !am_or_pm;
        }

        if (int_hours > 12) {
            int_hours = 1;
        }

        string print_hours, print_minutes, print_seconds;
        if (int_hours >= 10) {
            print_hours = int_hours.ToString();
        }
        else {
            print_hours = "0" + int_hours.ToString();
        }
        if (int_minutes >= 10) {
            print_minutes = int_minutes.ToString();
        }
        else {
            print_minutes = "0" + int_minutes.ToString();
        }
        if (int_seconds >= 10) {
            print_seconds = int_seconds.ToString();
        }
        else {
            print_seconds = "0" + int_seconds.ToString();
        }

        string string_am_or_pm;
        
        if (am_or_pm == true) {
            string_am_or_pm = "AM";
        }
        else {
            string_am_or_pm = "PM";
        }
            
        Print($"Time: {print_hours}:{print_minutes}:{print_seconds} {string_am_or_pm}");

    }
}