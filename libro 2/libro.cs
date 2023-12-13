using System;

public class Libro
{
    // Campi della classe Libro
    public string Titolo;
    public string Autore;
    public int AnnoPubblicazione;

    // Costruttore per inizializzare i campi
    public Libro(string titolo, string autore, int annoPubblicazione)
    {
        Titolo = titolo;
        Autore = autore;
        AnnoPubblicazione = annoPubblicazione;
    }

    // Metodo per visualizzare le informazioni del libro
    public void VisualizzaInfo()
    {
        Console.WriteLine($"Titolo: {Titolo}");
        Console.WriteLine($"Autore: {Autore}");
        Console.WriteLine($"Anno di Pubblicazione: {AnnoPubblicazione}");
    }
}

class Program
{
    static void Main()
    {
        //utilizzo della classe Libro
        Libro mioLibro = new Libro("L'arte di Insultare", "Arthur Schopenauer", 1999);
        mioLibro.VisualizzaInfo();



    }
}
