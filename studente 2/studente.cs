using System;

public class Studente
{
    // Campi della classe Studente
    public string Nome;
    public string Cognome;
    public int Matricola;
    
    // Costruttore della classe Studente
    public Studente(string nome, string cognome, int matricola)
    {
        Nome = nome;
        Cognome = cognome;
        Matricola = matricola;
    }

    // Metodo per indicare che lo studente sta studiando
    public void Studiare()
    {
        Console.WriteLine($"{Nome} {Cognome} sta studiando.");
    }

    // Metodo per visualizzare tutte le informazioni dello studente
    public void VisualizzaDati()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cognome: {Cognome}");
        Console.WriteLine($"Matricola: {Matricola}");
    }
}

class Program
{
    static void Main()
    {
        // Esempio di utilizzo della classe Studente
        Studente studente1 = new Studente("Franchino", "Bianchi",699666);
        studente1.VisualizzaDati(); // Visualizza informazioni dello studente
        studente1.Studiare(); // Mostra che lo studente sta studiando
    }
}

