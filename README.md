Oppgave C sharp første oppgave - psuedokode og tankekart

Oppgavebeskrivelsen:

I denne oppgaven skal dere først tegne opp og planlegge programmet ved hjelp av flytskjema eller pseudokode, før dere skriver selve koden. Programmet skal styres av enten en **if/else if/else-blokk** eller en **switch-case statement**.

Dere velger selv hva programmet skal gjøre, men her er noen mulige ideer for å komme i gang:

1. Et program som leser inn en temperaturvariabel, og basert på grenser dere definerer selv, gir tilbakemelding i terminalen om temperaturen.
    
2. Et program som sjekker hvor mange produkter en butikk har av en vare, og skriver ut hvor mye rabatt varen skal få basert på beholdningen.
    
3. Et program som sjekker lengden på en tekststreng (f.eks. med `.Length` på en string-variabel) og vurderer om det kan være et sterkt eller svakt passord.
    

Dette er kun forslag – prøv gjerne å tenke ut egne ideer som gjør programmet mer spennende eller nyttig! Tenk over hvordan dere kan bygge videre på grunnideen med flere betingelser eller utvidelser som utfordrer dere litt ekstra.

Legg også med en readme.txt fil sammen med koden din, hvor du limer inn planleggingen din, og hva verdier du har valgt for å teste din programflyt.  
F.eks hvis du har laget en if/else blokk som skjekker temperaturer, hvilke temperaturverdier har du testet koden din med. 

Alle grener i programmet bør planlegges på forhånd og skrives som pseudokode før dere går i gang med å kode.

### Levering

Oppgaven skal leveres som en link til et **GitHub-repo**.

Et tips: Når man laster opp C#-kode til GitHub, kan det komme med mange unødvendige filer. For å unngå dette kan dere generere en `.gitignore`-fil med kommandoen:

`dotnet new gitignore`


Oppgave: 
Lage et program som sjekker hvor mange produkter en butikk har av en vare, og så skriver ut hvor mye rabatt varen skal få basert på beholdningen. 

Utforsking og tillegg: 
La også til spørsmål om hva varen kostet opprinnelig og hvis det ble en rabatt basert på antall produkter, ble bruker presentert med hva produktet koster etter rabatten er satt hvis bruker ønsket. 

Og så en sluttsummering hvor bruker får oppsummert hva de ulike produktenes gjeldende pris er etter enten rabatt eller ikke basert på om det ble rabatt eller ikke. 

Kladd: 
Først introdusere
Be bruker skrive inn mengden av 3 ulike varer, en om gangen
Så be bruker skrive inn antall varer per produkt.  
Og så sjekke opp mot koden hvor mye prosent som skal gis basert på mengden. 
Så presentere rabatten til brukeren.

Så spørre bruker om den vil vite hva den nye prisen på produktet blir med rabatt
Må da skrive inn prisen på produktet og så regne ut og gi svaret.



Psuedokode/tankekart: 

Legger ved kommentert ut kode i programmet som var opprinnelig med før jeg måtte endre for å få til å legge inn "Gjeldende pris". Måtte ta det ut av if/else blokken for å få det til. Måtte også endre else if (antallBrødosv >=20) til kun "else" for å kunne kjøre koden etter endringen. Brukt litt codex når jeg satt fast lenge.

Kunne nok ha kortet koden ned med å unngå repetisjoner ved å legge inn en funksjon som kan brukes om igjen, men det får bli til senere. 

string brød = 1;
string melk = 2;
string mango = 3;

Console.WriteLine("Hei, velkommen til varetelling med rabatt!");

~~Console.WriteLine("Velg mellom disse 3 varene: " + brød + ", " + melk + ", " + mango);~~

Console.WriteLine("Hvor mange brød er det i butikken?")

int antallBrød = Convert.ToInt32(Console.ReadLine());

int antallMelk = Convert.ToInt32(Console.ReadLine());

int antallMango = Convert.ToInt32(Console.ReadLine());

if (antallBrød <= 20)

    Console.WriteLine("Brød skal være full pris");

else if (antallBrød >= 20)

    Console.WriteLine("Brød skal ha 20% rabatt");

Console.WriteLine("Hvor mange melk er det i butikken?");

int antallMelk = Convert.ToInt32(Console.ReadLine());

if (antallMelk <=20)
	Console.WriteLine("Melk skal være full pris");

else if (antallMelk >=20)
	Console.WriteLine("Melk skal ha 30% rabatt");
	{Console.WriteLine("Vil du vite hva prisen blir med rabatt?");
		Console.WriteLine("Skriv "Ja" eller "Nei");
		Console.ReadLine();
			if (jaTilRabattertPris == Ja)
					Console.WriteLine("Skriv inn originalprisen her: ");
					decimal originalPris = Convert.ToDecimal(Console.ReadLine());
				
						decimal rabattertPrisMelk = Convert.ToDecimal(originalPris * (30/100));
						decimal nyPrisMelk = Convert.ToDecimal(originalPris - rabattertPrisMelk);
				
			else if  (neiTilRabattertPris == Nei)
				 Console.WriteLine("Nei vel...");
	}

Console.WriteLine("Hvor mange mangoer er det i butikken?");

int antallMango = Convert.ToInt32(Console.ReadLine());

if (antallMango <= 20)
	Console.WriteLine("Mango skal være full pris");

else if (antallMango >= 20)
	Console.WriteLine("Mango skal ha 50% rabatt");
	

if 
Console.WriteLine("Vil du vite hva den nye prisen på )




Test av verdier i programflyten:

Testet ulike tall mellom 10 og 600 på alle 3 varene for både antall varer og pris. Og testet både Ja og Nei som svar på rabatten. Kunne ha endret koden til å godta både Ja og ja, men unnlot det.




