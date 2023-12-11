// Definire lista della spesa
List<string> lista = new List<string>();

Console.WriteLine("Inserisci elementi nella lista(digita 'fine' per terminare l'inserimento)");
string elemento;
while (true)
{
    Console.Write("Elemento: ");
    elemento = Console.ReadLine();
    if (elemento.ToLower() == "fine")
    { 
     break;
    }
    lista.Add(elemento);
}
// visualiazzione lista
Console.WriteLine("\n Lista della spesa:");
foreach (var oggetto in lista)
{
    Console.WriteLine($"-{oggetto}");
}
// Calcolo totale
int stimacosto = 3; // valore arbitrario
int totalespesa= CalcoloTotaleSpesa(lista,stimacosto);
Console.WriteLine($"\nTotale della Spesa: {totalespesa}, ");

//Ricerca elementi
Console.Write("\nInserisci l'elemento da cercare: ");
string searchelement= Console.ReadLine();
searchelementinlist(lista,searchelement);

static int CalcoloTotaleSpesa(List<string> lista, int stimacosto)
{
    int totalespesa=0;
    foreach(var elemento in lista)
    {
        totalespesa += stimacosto;
    }
    return totalespesa;
}
static void searchelementinlist(List<string> lista, string searchelement)
{
    bool findelement=false;
    double findelementcost = 0;
    foreach(var elemento in lista)
    { 
     if (elemento.Equals(searchelement, StringComparison.OrdinalIgnoreCase)) 
        { 
        findelement = true;
        findelementcost = 3; // sostiuisci con costo effettivo dell'elemento
            break;
       }
    }
    if (findelement)
    {
        Console.WriteLine($"L'elemento '{searchelement}' è presente nella lista e costa {findelementcost}");
    }
    else
    {
        Console.WriteLine($"L'elemento '{searchelement}'non è presente nella lista.");
    }
}
