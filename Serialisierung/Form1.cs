using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fahrzeugpark;
using Newtonsoft.Json;

namespace Serialisierung
{
    public partial class Form1 : Form
    {
        public List<Fahrzeug> FahrzeugListe { get; set; }
        private Random generator;

        public Form1()
        {
            InitializeComponent();

            //Initialisierung benötigter Variablen
            this.FahrzeugListe = new List<Fahrzeug>();
            this.generator = new Random();
        }

        #region Event-Methoden der Buttons
        private void btnNew_Click(object sender, EventArgs e)
        {
            ErzeugeNeuesFz();

            ZeigeFz();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Durchsuchen der ListBox nach markierten Einträgen (von unten, da evtl Einträge gelöscht werden)
            for (int i = lbxFahrzeuge.Items.Count - 1; i >= 0; i--)
            {
                if (lbxFahrzeuge.GetSelected(i))
                    FahrzeugListe.RemoveAt(i);
            }

            ZeigeFz();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SpeichereFz();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LadeFz();

            ZeigeFz();
        }
        #endregion

        //Methode zum Abspeichern von Fahrzeugen (vgl. auch SpeichernUndLaden.btnSave_Click())
        ///In dieser Methode wird mittels der Bibliothek Newtonsoft.Json eine SERIALISIERUNG (d.h. Umwandlung in ein abspeicherbares Format)
        ///der Fahrzeuge durchgeführt
        private void SpeichereFz()
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter("fahrzeuge.txt");

                //Mittels eines Objekts vom Typ JsonSerializerSettings kann dem Serialisierer mitgeteilt werden, dass er z.B. den Typ der
                ///abzuspeichernden Objekte mit abspeichert
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.TypeNameHandling = TypeNameHandling.Objects;

                for (int i = 0; i < lbxFahrzeuge.Items.Count; i++)
                {
                    if (lbxFahrzeuge.GetSelected(i))
                    {
                        //Umwandlung der OOP-Objekte in Strings
                        string umgewandeltesFz = JsonConvert.SerializeObject(FahrzeugListe[i], settings);
                        //Abspeichern des Strings
                        sw.WriteLine(umgewandeltesFz);
                    }
                }

                MessageBox.Show("Speichern erfolgreich");
            }
            catch
            {
                MessageBox.Show("Speichern fehlgeschlagen");
            }
            finally
            {
                sw?.Close();
            }

        }

        private void LadeFz()
        {
            //vgl. SpeichereFz()
            StreamReader sr = null;

            try
            {
                sr = new StreamReader("fahrzeuge.txt");

                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.TypeNameHandling = TypeNameHandling.Objects;

                while (!sr.EndOfStream)
                {
                    Fahrzeug fz = JsonConvert.DeserializeObject<Fahrzeug>(sr.ReadLine(), settings);
                    FahrzeugListe.Add(fz);
                }

                MessageBox.Show("Laden erfolgreich");
            }
            catch
            {
                MessageBox.Show("Laden fehlgeschlagen");
            }
            finally
            {
                sr?.Close();
            }
        }
        
        //Methode zur Anzeige der Fahrzeuge in der ListBox
        private void ZeigeFz()
        {
            //Leeren der ListBox
            lbxFahrzeuge.Items.Clear();

            //Hinzufügen der Fz-Namen zur ListBox
            foreach (var item in FahrzeugListe)
            {
                lbxFahrzeuge.Items.Add(item.Name);
            }
        }

        //Methode zur zufälligen Fahrzeug-Erzeugung
        private void ErzeugeNeuesFz()
        {
            switch (generator.Next(1, 4))
            {
                case 1:
                    FahrzeugListe.Add(new Schiff("Titanic", 40, 3000000.0, Schiff.Treibstoffart.Dampf));
                    break;

                case 2:
                    FahrzeugListe.Add(new Flugzeug("Boing", 980, 3500000.0, 9999));
                    break;

                case 3:
                    FahrzeugListe.Add(PKW.ErzeugeZufälligenPKW());
                    break;
                default:
                    break;
            }
        }

    }
}
