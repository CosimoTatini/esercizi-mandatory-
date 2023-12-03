// Password segreta
string passwordSegreta = "tucano";

do // ciclo do while per richiedere la password
{
    Console.Write("Inserisci la password: ");
    string passwordUtente = Console.ReadLine();

    // Verifica se la password è corretta
    if (passwordUtente == passwordSegreta)
    {
        Console.WriteLine("Complimenti la password è corretta!");
        return;  // Esci dal ciclo do-while se la password è corretta
    }
    else
    {
        Console.WriteLine("Mi dispiace la password è sbagliata! Riprova...");
    }

} while (true);
    
