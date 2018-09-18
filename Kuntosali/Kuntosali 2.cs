using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuntosali
{
    // Määritetään luokka Asiakas
    class Asiakas
    {
        // Asiakkaan attribuutit (ominaisuudet)
        string etunimi;
        string sukunimi;
        uint ika;
        bool mies;
        double pituus;
        double paino;
       
        // Olion muodostin (konstruktori)
        public Asiakas(string etunimi, string sukunimi, uint ika, bool mies, double pituus, double paino)
        {
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.ika = ika;
            this.mies = mies;
            this.pituus = pituus;
            this.paino = paino;
        }

        // Metodi, jolla lasketaan painoindeksi
        public void LaskeBMI()
        {
            double bmi = this.paino / (this.pituus * this.pituus);
            Console.WriteLine("Asiakkaan BMI on: " + bmi);
        }
        // Metodi tietojen tulostamiseen ruudulle
        public void TulostaHenkilötiedot()
        {
            Console.WriteLine("Asiakkaan etunimi on " + etunimi + ", sukunimi on " + sukunimi + " ja ikä on " + ika);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Käyttöliittymän muuttujat
            string eNimi;
            string sNimi;
            string asIka;
            string onMies;
            string asPaino;
            string asPituus;
            double paino;
            double pituus;
            bool mies;
            uint ika;

            // Kysytään käyttäjältä asiakastiedot
            Console.Write("Anna etunimi: ");
            eNimi = Console.ReadLine();
            Console.Write("Anna sukunimi: ");
            sNimi = Console.ReadLine();
            Console.Write("Anna ikä: ");
            asIka = Console.ReadLine();
            Console.Write("Anna paino: ");
            asPaino = Console.ReadLine();
            Console.Write("Anna pituus: ");
            asPituus = Console.ReadLine();
            Console.Write("Paina X, jos asiakas on mies; ");
            onMies = Console.ReadLine();

            // Muutetaan tekstinä annetut tiedot luvuiksi
            ika = UInt32.Parse(asIka); // Muunna 32 bittiseksi parse-metodilla
            paino = Double.Parse(asPaino); // Muunnos kaksoistarkkuuden liukuluvuksi
            pituus = Double.Parse(asPituus);

            // Tutkitaan onko käyttäjä painanut x-näppäintä
            if (onMies == "X")
            {
                mies = true
            }
            else
            // Luodaan ensimmäinen asiakas
            Asiakas asiakas1 = new Asiakas(eNimi,sNimi,ika,true);
            //Asiakas asiakas2 = new Asiakas("Harttu", "Toivonen", 30, true);
            Console.WriteLine("Asiakkaan 1 tiedot ovat:");
            asiakas1.TulostaHenkilötiedot();
            asiakas1.LaskeBMI()
            Console.ReadLine;
        
            //Console.WriteLine("Asiakkaan 2 tiedot ovat:");
            //asiakas2.TulostaHenkilötiedot();
            Console.ReadLine();
        }
    }
}
