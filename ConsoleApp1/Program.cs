// See https://aka.ms/new-console-template for more information


using System.Globalization;

public class Program 
{
    public static void Main(string[] args)
    {
        string sentence = "CodeAcademy is a good place to study";
        string[] result = sentence .Split(' ');
        Console.WriteLine($"Total number of words in the string is:{result.Length}");


    }
}

