using System;

public class AuthenticationSystem
{
    private static string storedUsername = "admin";
    private static string storedPassword = "password";

    public static void Main(string[] args)
    {
        Console.WriteLine("Authentication System");
        Console.WriteLine("MineName");

        bool isAuthenticated = AuthenticateUser();

        if (isAuthenticated)
        {
            Console.WriteLine("\nUser authenticated successfully.");
        }
        else
        {
            Console.WriteLine("\nAuthentication failed. Invalid username or password.");
        }
    }

    private static bool AuthenticateUser()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (username == storedUsername && password == storedPassword)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

