using System;

public class Program
{
    public static void Main()
    {
        int enemy_health = 100;
        Console.WriteLine("Enemy Health: " + enemy_health);

        double game_currency = 2500.50;
        Console.WriteLine("Game Currency: " + game_currency);

        string player_name = "Alex Sown";
        Console.WriteLine("Player Name: " + player_name);

        bool isalive = true;
        Console.WriteLine("Is Alive: " + isalive);

        char patrol_state = 'S';
        Console.WriteLine("Patrol State: " + patrol_state);

        byte player_age = 25;
        Console.WriteLine("Player Age: " + player_age);

        long score = 1000000000L; 
        Console.WriteLine("Score: " + score);

        decimal price = 100.50m;
        Console.WriteLine("Price: " + price);

        string null_variable = null;
        Console.WriteLine("Null Variable: " + null_variable);

        float speed = 100.50f;
        Console.WriteLine("Speed: " + speed);

        Console.WriteLine("--------------------------------------");
        
        ShowConstants();
    }

    public static void ShowConstants()
    {
        // Part 17: Hằng số Pi
        const double Pi = 3.14159;
        Console.WriteLine("Pi: " + Pi);

        // Part 18: Tên công ty
        const string CompanyName = "ABC Corporation";
        Console.WriteLine("Company: " + CompanyName);

        // Part 19: Số lần thử lại tối đa
        const int MaxRetries = 3;
        Console.WriteLine("Max Retries: " + MaxRetries);

        // Part 20: Gia tốc trọng trường
        const double Gravity = 9.8;
        Console.WriteLine("Gravity: " + Gravity);

        // Part 21: Số tháng trong năm
        const int MonthsInYear = 12;
        Console.WriteLine("Months in Year: " + MonthsInYear);
    }
}