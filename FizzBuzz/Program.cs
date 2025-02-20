using System;

internal class FizzBuzz
{
    public static string GetFizzBuzzString(int input)
    {
        if (input % 3 == 0 && input % 5 == 0) return "FizzBuzz";
        if (input % 3 == 0) return "Fizz";
        if (input % 5 == 0) return "Buzz";
        return input.ToString();
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine(FizzBuzz.GetFizzBuzzString(3));  // Salida: Fizz
        Console.WriteLine(FizzBuzz.GetFizzBuzzString(5));  // Salida: Buzz
        Console.WriteLine(FizzBuzz.GetFizzBuzzString(15)); // Salida: FizzBuzz
        Console.WriteLine(FizzBuzz.GetFizzBuzzString(7));  // Salida: 7
    }
}