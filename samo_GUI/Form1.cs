//using Rozpoznawanie_stron;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samo_GUI
{
    public partial class Form1 : Form
    {
        private const int ile_serwisow = 2; //ile internetowych serwisow mozna odpytac o analize adresu
        private bool czy_pytac_inne_serwisy;
        private String adresURL;
        private String[] nazwy_serwisow;
        private int[] wyniki_analizy;
        public Form1()
        {
            InitializeComponent();
            czy_pytac_inne_serwisy = false;
            nazwy_serwisow = new string[ile_serwisow];
            nazwy_serwisow[0] = "\"VirusTotal\"";
            nazwy_serwisow[1] = "\"InnySerwis\"";
            wyniki_analizy = new int[ile_serwisow + 1];
            int a;
            for (a = 0; a < (ile_serwisow + 1); a++)
            {
                wyniki_analizy[a] = 0;
            }
        }

        private void przycisk_Click(object sender, EventArgs e)
        {
            String opis_wyniku = "";
            adresURL = PoleAdresu.Text;
            if (adresURL.Length > 2 && czy_to_URL_internetowy())
            {
                badaj_adres();
                opis_wyniku = "Rezultaty - czy adres prowadzi do szkodliwej strony:\n";
                opis_wyniku += "nasze AI: ten adres jest ";
                if (wyniki_analizy[0] == 1) { opis_wyniku += "bezpieczny"; }
                else if (wyniki_analizy[0] == 0) { opis_wyniku += "podejrzany"; }
                else { opis_wyniku += "niebezpieczny"; }
                if (czy_pytac_inne_serwisy)
                {
                    opis_wyniku += "\n";
                    int a;
                    for (a = 0; a < ile_serwisow; a++)
                    {
                        opis_wyniku += nazwy_serwisow[a] + ": ten adres ";
                        if (wyniki_analizy[a+1] == 1) { opis_wyniku += "nie "; }
                        opis_wyniku += "jest szkodliwy.\n";
                    }
                }
            }
            else 
            {
                opis_wyniku = "Nie podano adresu URL";
            }
            PoleWyniku.Visible = true;
            PoleWyniku.Text = opis_wyniku;
            PoleWyniku.Refresh();
        }

        private void CheckBoxInnych_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxInnych.Checked)
            {
                czy_pytac_inne_serwisy = true;
            }
            else
            {
                czy_pytac_inne_serwisy = false;
            }
        }

        private bool czy_to_URL_internetowy()
        {
            bool werdykt = true;
            //[tu sprawdza czy to adres strony internetowej (sprawdza semantyke)]
            //---
            return werdykt;
        }

        private void badaj_adres()
        {
            wyniki_analizy[0] = niech_AI_bada_adres();
            if (czy_pytac_inne_serwisy)
            {
                int[] od_serwisow = new int[ile_serwisow];
                od_serwisow = niech_serwisy_badaja_adres();
                int a;
                for (a = 1; a < (ile_serwisow + 1); a++)
                {
                    wyniki_analizy[a] = od_serwisow[a-1];
                }
            }
        }

        /*
         Result
         -1 = phishing
          0 = suspicious
          1 = legitimate
         */
        private int niech_AI_bada_adres()
        {
            float[] opis = Pomocne_Funkcje.opisz_adres_liczbami(adresURL);
            Samo_GUI.MLModel1.ModelInput testowy_input = Pomocne_Funkcje.tabelke_zmien_na_opis_dla_AI(opis);
            Samo_GUI.MLModel1.ModelOutput whole_output = Samo_GUI.MLModel1.Predict(testowy_input);
            //float wynikowy_label = whole_output.PredictedLabel;
            return (int)whole_output.PredictedLabel;
        }

        private int[] niech_serwisy_badaja_adres()
        {
            int[] czy_jest_bezpieczny = new int[ile_serwisow];
            int a;
            for (a = 0; a < ile_serwisow; a++) 
            { czy_jest_bezpieczny[a] = 1; }
            //[odpytanie serwisow internetowych o analize adresu]
            return czy_jest_bezpieczny;
        }

        
    }
}
