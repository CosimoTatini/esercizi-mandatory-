using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Inserisci la tua età: ");
            string input = Console.ReadLine();

            int age = ValidateAge(input);

            Console.WriteLine($"Età valida: {age} anni");
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine($"Errore: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Errore sconosciuto: {ex.Message}");
        }
    }

    static int ValidateAge(string input)
    {
        if (!int.TryParse(input, out int age) || age < 0)
        {
            throw new InvalidAgeException("L'età deve essere un numero intero positivo.");
        }

        return age;
    }
}

class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {
    }
}

