using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Inserisci il percorso completo del file che vuoi leggere
        string percorsoFile = "C:\\Users\\STUDENTE\\Desktop\\file.txt";

        try
        {
            // Leggi il contenuto del file
            string contenuto = LeggiContenutoFile(percorsoFile);

            // Stampa il contenuto del file
            Console.WriteLine("Contenuto del file:");
            Console.WriteLine(contenuto);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Il file '{percorsoFile}' non esiste.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine($"Accesso negato al file '{percorsoFile}'. Verifica i permessi di accesso.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Si è verificato un errore: {ex.Message}");
        }
    }

    static string LeggiContenutoFile(string percorso)
    {
        // Utilizza la classe StreamReader per leggere il contenuto del file
        using (StreamReader reader = new StreamReader(percorso))
        {
            // Restituisci il contenuto del file come stringa
            return reader.ReadToEnd();
        }
    }
}
