using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Inserisci un username: ");
            string username = Console.ReadLine();

            ValidateUsername(username);

            Console.WriteLine("Username valido!");
        }
        catch (InvalidUsernameException ex)
        {
            Console.WriteLine($"Errore: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Errore sconosciuto: {ex.Message}");
        }
    }

    static void ValidateUsername(string username)
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            throw new InvalidUsernameException("L'username non può essere vuoto o contenere solo spazi.");
        }

        if (username.Length < 5)
        {
            throw new InvalidUsernameException("L'username deve contenere almeno 5 caratteri.");
        }

        if (!char.IsLetter(username[0]))
        {
            throw new InvalidUsernameException("L'username deve iniziare con una lettera.");
        }

        foreach (char c in username)
        {
            if (!char.IsLetterOrDigit(c) && c != '_')
            {
                throw new InvalidUsernameException($"L'username può contenere solo lettere, numeri e il carattere underscore (_). Carattere non valido: {c}");
            }
        }
    }
}

class InvalidUsernameException : Exception
{
    public InvalidUsernameException(string message) : base(message)
    {
    }
}

