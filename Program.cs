Console.WriteLine("Hei, velkommen til varetelling med rabatt!");


Console.WriteLine("Hvor mange brød er det i butikken?");

int antallBrød = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Skriv inn originalprisen til brød her: ");
decimal originalPrisBrød = Convert.ToDecimal(Console.ReadLine());

decimal gjeldendePrisBrød;

if (antallBrød <= 20)
{
    Console.WriteLine("Brød skal være full pris");

    gjeldendePrisBrød = originalPrisBrød;
}
else // if (antallBrød >= 20)
{
    Console.WriteLine("Brød skal ha 20% rabatt");
    gjeldendePrisBrød = originalPrisBrød * 0.8m;

    Console.WriteLine("Vil du vite hva prisen blir med rabatt?");
    Console.WriteLine("Skriv \"Ja\" eller \"Nei\"");
    string valgAvRabattertPrisBrød = Console.ReadLine();

    if (valgAvRabattertPrisBrød == "Ja")
    {
        /*     Console.WriteLine("Skriv inn originalprisen her: ");
            decimal originalPrisBrød = Convert.ToDecimal(Console.ReadLine()); */
        decimal rabattertPrisBrød = Convert.ToDecimal(originalPrisBrød * (20m / 100m));
        Console.WriteLine(rabattertPrisBrød);
        decimal nyPrisBrød = Convert.ToDecimal(originalPrisBrød - rabattertPrisBrød);
        Console.WriteLine("Rabattert pris på brød blir " + nyPrisBrød + "kr");
        decimal oppdatertPrisBrød = nyPrisBrød;
    }
    else if (valgAvRabattertPrisBrød == "Nei")

        Console.WriteLine("Nei vel...");
}

Console.WriteLine("Hvor mange melk er det i butikken?");

int antallMelk = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Skriv inn originalprisen til melk her: ");
decimal originalPrisMelk = Convert.ToDecimal(Console.ReadLine());

decimal gjeldendePrisMelk;

if (antallMelk <= 20)
{
    Console.WriteLine("Melk skal være full pris");
    gjeldendePrisMelk = originalPrisMelk;
}
else // if (antallMelk >= 20)
{
    Console.WriteLine("Melk skal ha 30% rabatt");
    gjeldendePrisMelk = originalPrisMelk * 0.7m;
}

Console.WriteLine("Vil du vite hva prisen blir med rabatt?");
Console.WriteLine("Skriv \"Ja\" eller \"Nei\"");
string valgAvRabattertPrisMelk = Console.ReadLine();

if (valgAvRabattertPrisMelk == "Ja")
{
    // Console.WriteLine("Skriv inn originalprisen her: ");
    // decimal originalPrisMelk = Convert.ToDecimal(Console.ReadLine());
    decimal rabattertPrisMelk = Convert.ToDecimal(originalPrisMelk * (30m / 100m));
    Console.WriteLine(rabattertPrisMelk);
    decimal nyPrisMelk = Convert.ToDecimal(originalPrisMelk - rabattertPrisMelk);
    Console.WriteLine("Rabattert pris på melk blir " + nyPrisMelk + "kr");
}
else if (valgAvRabattertPrisMelk == "Nei")

    Console.WriteLine("Nei vel...");


Console.WriteLine("Hvor mange mangoer er det i butikken?");

int antallMango = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Skriv inn originalprisen til mango her: ");
decimal originalPrisMango = Convert.ToDecimal(Console.ReadLine());

decimal gjeldendePrisMango;

if (antallMango <= 20)
{
    Console.WriteLine("Mango skal være full pris");
    gjeldendePrisMango = originalPrisMango;
}
else // if (antallMango >= 20)
{
    Console.WriteLine("Mango skal ha 50% rabatt");
    gjeldendePrisMango = originalPrisMango * 0.5m;
}

Console.WriteLine("Vil du vite hva prisen blir med rabatt?");
Console.WriteLine("Skriv \"Ja\" eller \"Nei\"");
string valgAvRabattertPrisMango = Console.ReadLine();

if (valgAvRabattertPrisMango == "Ja")
{
    // Console.WriteLine("Skriv inn originalprisen her: ");
    // decimal originalPrisMango = Convert.ToDecimal(Console.ReadLine());
    decimal rabattertPrisMango = Convert.ToDecimal(originalPrisMango * (50m / 100m));
    Console.WriteLine(rabattertPrisMango);
    decimal nyPrisMango = Convert.ToDecimal(originalPrisMango - rabattertPrisMango);
    Console.WriteLine("Rabattert pris på mango blir " + nyPrisMango + "kr");
}
else if (valgAvRabattertPrisMango == "Nei")

    Console.WriteLine("Nei vel...");


Console.WriteLine("Gjeldende pris på varene er som følgende: ");
Console.WriteLine("Brød: " + gjeldendePrisBrød);
Console.WriteLine("Melk: " + gjeldendePrisMelk);
Console.WriteLine("Mango: " + gjeldendePrisMango);