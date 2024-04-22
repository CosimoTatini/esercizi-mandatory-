using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> listaNumeri = new List<int>();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Aggiungi numero");
            Console.WriteLine("2. Rimuovi numero");
            Console.WriteLine("3. Visualizza tutti i numeri");
            Console.WriteLine("4. Esci");

            Console.Write("Seleziona un'opzione (1-4): ");
            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    AggiungiNumero(listaNumeri);
                    break;

                case "2":
                    RimuoviNumero(listaNumeri);
                    break;

                case "3":
                    VisualizzaNumeri(listaNumeri);
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opzione non valida. Riprova.");
                    break;
            }
        }
    }

    static void AggiungiNumero(List<int> lista)
    {
        Console.Write("Inserisci un numero intero da aggiungere: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            lista.Add(numero);
            Console.WriteLine($"Il numero {numero} è stato aggiunto alla lista.");
        }
        else
        {
            Console.WriteLine("Inserimento non valido. Assicurati di inserire un numero intero.");
        }
    }

    static void RimuoviNumero(List<int> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("La lista è vuota. Non ci sono elementi da rimuovere.");
            return;
        }

        Console.Write("Inserisci l'indice del numero da rimuovere: ");
        if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < lista.Count)
        {
            int numeroRimosso = lista[indice];
            lista.RemoveAt(indice);
            Console.WriteLine($"Il numero {numeroRimosso} è stato rimosso dalla lista.");
        }
        else
        {
            Console.WriteLine("Indice non valido. Assicurati di inserire un indice valido.");
        }
    }

    static void VisualizzaNumeri(List<int> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("La lista è vuota. Non ci sono elementi da visualizzare.");
        }
        else
        {
            Console.WriteLine("Numeri nella lista:");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"{i}. {lista[i]}");
            }
        }
    }
}

