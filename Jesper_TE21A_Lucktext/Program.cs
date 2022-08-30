string name;

name = "Jesper";

Console.WriteLine("Vad heter du?");
name = Console.ReadLine();

Console.WriteLine($"Tja {name}");
// Console.WriteLine(name);

// Console.WriteLine("Vill du spela spelet?");
// Console.WriteLine("Om du vill spela skriv 'ja', om du inte vill spela skriv 'nej' ");

// Console.ReadLine();

Console.WriteLine("Fråga nummer ett:");

string dryck;

dryck = "Cola";

Console.WriteLine("Vad är din favorit dryck?");

dryck = Console.ReadLine();

Console.WriteLine("Fråga två:");
Console.WriteLine("Vad är din favorit maträtt?");

string mat ;

mat = "Pizza";

mat = Console.ReadLine();

Console.WriteLine("Fråga 3");
Console.WriteLine("Vad är din hobby?");

string hobby ;

hobby = "Spela fotboll" ;

hobby = Console.ReadLine();

Console.WriteLine("Bra, Du har nu gjort färdigt personlighets spelet.");

Console.WriteLine("Här kommer resultaten:");

//string name ;
Console.WriteLine($"Du heter {name}, när det kommer till dricka är ditt förstahandsval {dryck}. När du inte är i skolan gillar du att {hobby}");

Console.WriteLine("Tack för att du spelade");

Console.ReadLine() ;