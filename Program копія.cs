using System;
using System.IO;

public class TextEditor
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Text Editor");
        Console.WriteLine("MineEditor");

        string filePath = PromptFilePath();

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("\nFile Contents:");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Please make sure the file exists and try again.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    private static string PromptFilePath()
    {
        Console.Write("Enter the path of the file to open: ");
        string filePath = Console.ReadLine();
        return filePath;
    }
}
