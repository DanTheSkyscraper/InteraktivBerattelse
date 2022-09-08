Console.WriteLine("En onsdag morgon vaknar du. Du ska gå till skolan idag. Det finns däremot ett problem. Du mår illa, men samtidigt har du ett projekt som ska göras i skolan. Tänker du stanna hemma och vila, eller kommer du att gå till skolan? Snälla svara på engelska. [go to school/do not go to school]");

string val1 = Console.ReadLine().ToLower(); // Skriv svar på engelska
//string för val1 gör att man skapar en variabel för det valet, så att man kan sedan välja nästa alternativ.
if (val1 == "go to school")
{
    Console.WriteLine("Du bestämmer dig för att gå till skolan. Tänker du gå med buss eller tåg? [bus/train]");
    string val1a = Console.ReadLine().ToLower();
    if (val1a == "bus") // Följande val har kallats "val1a" för att programmet inte ska förvirra if-satsen och stringen inuti if-satsen.
    {
        Console.WriteLine("Du bestämmer dig för att ta bussen till skolan. Du hinner i tid och gör projektet. [Ending 1a]");
    }
    else if (val1a == "train") // Om man inte väljer att åka bussen så kommer koden istället göra så att man åker tåget.
    {
        Console.WriteLine("Du bestämmer dig för att ta tåget till skolan. Du hinner i tid och gör projektet. [Ending 1b]");
    }
}
//string för val2 gör att man skapar en variabel för det valet, så att man kan sedan välja nästa alternativ.
else if (val1 == "do not go to school")
{
    Console.WriteLine("Du bestämmer dig för att inte gå till skolan. Vad tänker du göra istället? Vila eller studera? [rest/study]");
    string val1b = Console.ReadLine().ToLower();
    if (val1b == "rest") // Följande val har kallats "val2a" för att programmet inte ska förvirra if-satsen och stringen inuti if-satsen.
    {
        Console.WriteLine("Du bestämmer dig för att vila. Du meddelar läraren om din hälsa och lyckas komma överens att göra projektet en annan tid. [Ending 2a]");
    }
    else if (val1b == "study") // Om inte skriver att man vill vila så kommer koden istället att skriva att man studerar.
    {
        Console.WriteLine("Du bestämmer dig för att studera. Du meddelar läraren och frågar om du kan göra projektet en annan tid. Ni kommer överens att du gör den en annat tid, och du får istället en hemuppgift att göra tills nästa vecka. [Ending 2B]");
    }
}

Console.ReadLine();
