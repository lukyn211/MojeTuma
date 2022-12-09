using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_ke_zkoušce
{
    internal class DatabazePojistencu
        
    {
        /// <summary>
        /// Seznam pojištěnců
        /// </summary>
        List<Pojistenec> pojistenci = new List<Pojistenec>();
        /// <summary>
        /// Přidá pojištěnce
        /// </summary>
        public void PridejPojistence()
        {
            
            Console.WriteLine("\nZadejte jméno pojištěnce:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("\nZadej přijmení pojištěnce:");
            string prijmeni = Console.ReadLine();
            Console.WriteLine("\nZadej věk pojištěnce:");
            int vek = int.Parse(Console.ReadLine());
            Console.WriteLine("\nZadej telefoní číslo:");
            int telefoniCislo = int.Parse(Console.ReadLine());
            pojistenci.Add(new Pojistenec(jmeno, prijmeni, vek, telefoniCislo));
        }
        /// <summary>
        /// Vypíše seznam pojištěnců
        /// </summary>
        public void VypisPojistencu()
        {
            if (pojistenci.Count > 0)
                foreach (Pojistenec p in pojistenci)
                {
                    Console.WriteLine(p);
                }
            else
                Console.WriteLine("Databáze je prázdná");
        }
        /// <summary>
        /// Vypíše daného pojištěnce
        /// </summary>
        public void VyhledejPojistence()
        {
            //Vypíš jméno a přijmení 
            Console.WriteLine("Zadej jméno pojištěnce:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadej přijmení pojištěnce:");
            string prijmeni = Console.ReadLine();
            foreach(Pojistenec p in pojistenci)
                if((p.Jmeno == jmeno) && (p.Prijmeni == prijmeni))
                {
                    Console.WriteLine(p);
                }
            else
                    Console.WriteLine("Zadaný uživatel nebyl nalezen.");
        }
    }
}
