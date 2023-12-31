using System;

class Calculator
{
    static void Main()
    {
        try
        {
            Console.Write("Inserisci un'espressione matematica: ");
            string input = Console.ReadLine();

            double result = CalculateExpression(input);

            Console.WriteLine("Risultato: " + result);
        }
        catch (InvalidExpressionException ex)
        {
            Console.WriteLine("Errore: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Errore generico: " + ex.Message);
        }
    }

    static double CalculateExpression(string expression)
    {
        try
        {
            // Esegui il calcolo utilizzando il metodo di valutazione dell'espressione
            return EvaluateExpression(expression);
        }
        catch (Exception ex)
        {
            // Se si verifica un errore durante il calcolo, genera un'eccezione personalizzata
            throw new InvalidExpressionException("Espressione non valida", ex);
        }
    }

    static double EvaluateExpression(string expression)
    {
        // Verifica la divisione per zero prima di eseguire il calcolo
        if (expression.Contains("/0"))
        {
            throw new InvalidExpressionException("Divisione per zero non consentita");
        }

        // Utilizza la classe DataTable per eseguire la valutazione dell'espressione
        System.Data.DataTable table = new System.Data.DataTable();
        return Convert.ToDouble(table.Compute(expression, string.Empty));
    }
}

// Eccezione personalizzata per gestire errori di espressione non valida
class InvalidExpressionException : Exception
{
    public InvalidExpressionException(string message) : base(message)
    {
    }

    public InvalidExpressionException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
