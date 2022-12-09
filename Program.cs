using Projekt_ke_zkoušce;
DatabazePojistencu pojistencu = new DatabazePojistencu();
char volba = '0';
//hlavní cyklus 
while (volba != '4')
{
    Console.WriteLine();
    Console.WriteLine("Vyberte akci:");
    Console.WriteLine("-1- Přidat pojištěnce");
    Console.WriteLine("-2- Výpis pojištěnců");
    Console.WriteLine("-3- Vyhledej pojištěnce");
    Console.WriteLine("-4- Konec programu");
    volba = Console.ReadKey().KeyChar;
    Console.WriteLine();
   
    //volba aplikace
    switch (volba)
    {
        case '1':
            pojistencu.PridejPojistence();
            break;
        case '2':
            pojistencu.VypisPojistencu();
            break;
        case '3':
            pojistencu.VyhledejPojistence();
            break;
        case '4':
            Console.WriteLine("Přeji přijemný den");
            break;    
    }
}


