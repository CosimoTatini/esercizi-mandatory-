int punteggio = 0;
int punteggio2 = 0;
int differenzapunteggio = 0;
int giocatore = 0;
int i = 0;
var nomigiocatore= new System.Collections.Generic.Dictionary<string,int>();
while (true)
{
    Console.WriteLine("Inserisci il nome del giocatore(scrivi 'fine' per uscire):");
    string nomegiocatore= Console.ReadLine();
    if (nomegiocatore.ToLower() == "fine")
    {
        break;
    }

    Console.WriteLine("Scrivi il tuo punteggio");
    int puntigiocatore;
    while (!int.TryParse (Console.ReadLine(), out puntigiocatore))
    { Console.WriteLine("Input invalido");
    }
    nomigiocatore[nomegiocatore] = puntigiocatore;
}

Console.WriteLine("\nGiocatori e punti:");
foreach (var nomi in nomigiocatore)
{
    Console.WriteLine($"{nomi.Key}:{nomi.Value} punti");
}
MostraDifferenza(nomigiocatore);
static void MostraDifferenza(System.Collections.Generic.Dictionary <string,int> nomigiocatore)
{
    Console.WriteLine("\nDifferenza punti:");
}
foreach (var giocatore1 in nomigiocatore)
{
 foreach (var giocatore2 in nomigiocatore)
    { 
    if (giocatore1.Key != giocatore2.Key)
        {
            differenzapunteggio = Math.Abs(giocatore1.Value - giocatore2.Value);
            Console.WriteLine($"{giocatore1.Key} - {giocatore2.Key}: {differenzapunteggio}");
        }
    }
}
if (differenzapunteggio < 10)
{
   
    Console.WriteLine("Partita equilibrata");


}
else if (differenzapunteggio >=10 && differenzapunteggio <=20)
{
    Console.WriteLine("Partita interessante");
}
else if (differenzapunteggio > 20)
{
    Console.WriteLine("Partita intensa");
}
