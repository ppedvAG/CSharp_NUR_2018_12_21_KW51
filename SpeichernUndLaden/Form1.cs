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

namespace SpeichernUndLaden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Deklaration und Initialisierung eines OpenFileDialogs zur Auswahl der zu ladenden Datei 
            OpenFileDialog openDialog = new OpenFileDialog();

            //Einstellung diverser Parameter das Dialogs
            ///Angabe des Default-Dateinamens
            openDialog.FileName = "speicherString.txt";
            //Angabe das Default-Ordners
            openDialog.InitialDirectory = "C:\\";
            //Angabe der möglichen Dateiformate
            openDialog.Filter = "Textdatei|*.txt|StringDatei|*.string|Alle Dateien|*.*";

            //Öffnend des Dialogfensters und Abfrage der Benutzerauswahl
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //Deklaration eines StreamReaders und Initialisierung mit null, damit in jedem Block darauf zugegriffen werden kann
                StreamReader sr = null;

                //Ausführung der Speicherroutine in einem TRY-Block
                try
                {
                    //Instanzierung des StreamReaders mit Übergabe des gewähten Ladeortes
                    sr = new StreamReader(openDialog.FileName);

                    //Leeren der Textbox
                    tbxInput.Clear();

                    //Laden der Dateiinhalte in einer while-Schleife
                    while (!sr.EndOfStream)
                    {
                        //ReadLine() liest eine Zeile in der Datei aus und gibt diese an den Aufrufer
                        tbxInput.Text += sr.ReadLine() + "\r\n"; //<-- \r="carriage return" \n= "new line" Nur diese Reihenfolge erbringt eine neue Zeile in der Textbox
                    }

                    //Erfolgsmeldung
                    MessageBox.Show("Laden erfolgreich");
                }
                catch (Exception)
                {
                    //Misserfolgsmeldung
                    MessageBox.Show("Laden fehlgeschlagen");
                }
                finally
                {
                    //Schließen des Streams, damit andere Programme darauf zugreifen können (? = Nullprüfung)
                    sr?.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //vgl. auch btnLoad_Click()
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.FileName = "speicherString.txt";

            saveDialog.InitialDirectory = "C:\\";

            saveDialog.Filter = "Textdatei|*.txt|StringDatei|*.string|Alle Dateien|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = null;

                try
                {
                    sw = new StreamWriter(saveDialog.FileName);

                    //Schreiben des Textes mittels des StreamWriters in die Datei
                    sw.WriteLine(tbxInput.Text);

                    MessageBox.Show("Speichern erfolgreich");
                }
                catch (Exception)
                {
                    MessageBox.Show("Speichern fehlgeschlagen");
                }
                finally
                {
                    //if (sw != null)
                    //    sw.Close();

                    //Alternative Kurzschreibweise
                    sw?.Close();
                }
            }
        }

    }
}
