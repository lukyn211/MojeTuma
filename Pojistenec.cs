using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_ke_zkoušce
{
    internal class Pojistenec
    {
        /// <summary>
        /// Jméno pojištěnce
        /// </summary>
        /// vlastnost
        public string Jmeno { get; private set; }
        /// <summary>
        /// Příjmení pojištěnce
        /// </summary>
        /// vlastnost
        public string Prijmeni { get; private set; }
        /// <summary>
        /// Věk pojištěnce
        /// </summary>
        /// vlastnost
        public int Vek { get; private set; }
        /// <summary>
        /// Telefoní číslo pojištěnce
        /// </summary>
        /// vlastnost
        public int TelefoniCislo { get; private set; }
        /// <summary>
        /// inicializace Pojištěnce
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="vek"></param>
        /// <param name="telefoniCislo"></param>
        /// konstruktor
        public Pojistenec( string jmeno, string prijmeni, int vek, int telefoniCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefoniCislo = telefoniCislo; 
        }
        
        
       /// <summary>
       /// Vrací textovou podobu dané atributy pojištěnce
       /// </summary>
       /// <returns></returns>
       /// override pretížení
        public override string ToString()
        {
            return "Jméno:" + Jmeno + "     "+ "Příjmení:" + Prijmeni + "     " + "Věk pojištěnce:" + Vek + "     " + "Telefoní číslo pojištěnce:" + "" + TelefoniCislo;
        }
    }
    
}
