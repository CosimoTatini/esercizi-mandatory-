
{
    {
        Console.WriteLine("Inserisci la lunghezza del lato del triangolo:");
        
        // Leggi la lunghezza inserita dall'utente
        if (int.TryParse(Console.ReadLine(), out int lunghezza))
        {
            // Disegna il triangolo
            DisegnaTriangolo(lunghezza);
        }
        else
        {
            Console.WriteLine("Inserisci un valore valido.");
        }
    }

    static void DisegnaTriangolo(int lunghezza)
    {
        for (int i = 1; i <= lunghezza; i++)
        {
            // Stampa gli spazi bianchi a sinistra del triangolo
            for (int j = 0; j < lunghezza - i; j++)
            {
                Console.Write(" ");
            }

            // Stampa gli asterischi del triangolo
            for (int j = 0; j < 2 * i - 1; j++)
            {
                Console.Write("*");
            }

            // Vai a una nuova linea dopo aver stampato una riga del triangolo
            Console.WriteLine();
        }
    }
}
