using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creazione del dizionario città-codice postale
        Dictionary<string, string> dizionarioCodiciPostali = new Dictionary<string, string>
        {
            {"Roma", "00100"},
            {"Milano", "20100"},
            {"Napoli", "80100"},
            // Aggiungi altre città e codici postali secondo necessità
        };

        // Chiedi all'utente di inserire il nome della città
        Console.Write("Inserisci il nome della città: ");
        string nomeCitta = Console.ReadLine();

        // Cerca il codice postale nella mappa delle città
        if (dizionarioCodiciPostali.ContainsKey(nomeCitta))
        {
            string codicePostale = dizionarioCodiciPostali[nomeCitta];
            Console.WriteLine($"Il codice postale di {nomeCitta} è: {codicePostale}");
        }
        else
        {
            Console.WriteLine($"La città {nomeCitta} non è presente nel dizionario.");
        }
    }
}


