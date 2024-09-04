namespace Oppgave_uke_1;

class Program
{
    static void Main(string[] args)
    {

            // Lag en variabel av datatypen integer og tildel den et vilkårlig heltall
    int num = 12;
    // Lag en variabel av datatypen string og tilden en vilkårlig tekst
    string text = "Heia Bloggen!";
    // Lag en variabel av datatypen double og tilden et vilkårlig tall, både desimal og heltall er gyldig med denne typen
    double desmial = 3.14159;
    // Lag en variabel av datatypen char og tildel den en vilkårlig karakter(bokstav)
    char letter = 'A' ;
    // Lag et Array av datatypen integer og skriv ut verdiene med en vanlig for-løkke
    int[] ints = [38,39,40,41,42];

    for (int i = 0; i < ints.Length; i++)
    { Console.WriteLine(ints[i]);  
    }

    // Lag et Array av datatypen string og skriv ut verdiene med en foreach-løkke
    string[] strings = ["Bandit","Chilli", "Bluey", "Bingo"];
    foreach (string i in strings)
    {Console.WriteLine(i);  
        
    }

    // Lag en List av datatypen string og tildel verdier ved hjelp av List sin innebygde metode "Add()"
    List<string> byer = new List<string>();
    byer.Add("Bergen");
    byer.Add("Stavanger");
    // Legg til flere strings i listen deres
    byer.Add("Trondheim");
    byer.Add("Kirkenes");

    // Skriv ut verdiene i listen ved hjelp av en foreach-løkke
foreach (string i in byer)
{Console.WriteLine(i);  
    
}
// Oppgave 3: Ekstraoppgaver
// Ekstraoppgave(valgfritt)
// Disse oppgavene er valgfrie, men kan være lurt å forsøke å gjøre om man ønsker å begynne litt tidligere på de neste temaene i faget.
// Lag en Dictionary med integer-nøkkel og string-verdi slik
// Dictionary<int, string> myDictionary = new Dictionary<int, string>();
  Dictionary<int, string> dictionary1 = new Dictionary<int, string>
        {
            {1, "Hei"},
            {2, "Jørgen"},
            {3, "har"},
            {4, "du"},
            {5, "det"},
            {6, "bra?"}
            
        };
        // Skriv ut verdiene i Dictionary ved å anvende en foreach-løkke ved hjelp av datatypen var

          foreach (var dic in dictionary1)
        {

           Console.WriteLine($"{dic.Key} {dic.Value}");
        };



// Lag en metode av typen integer som legger sammen to tall, int a og int b
int a = 5;
int b = 6;
int sum = a + b;
Console.WriteLine(sum);
// Lag en metode av typen string som skrive ut en liten hilsen til brukeren ved å bruke en parametervariabel.

static void Hello(String hilsen ){
    Console.WriteLine(hilsen + ", Bloggen!");
}
Hello("Heia");



}
}