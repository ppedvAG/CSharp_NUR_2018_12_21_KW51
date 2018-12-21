using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEvents
{
    //PARTIAL besagt, dass die Klasse hier nicht vollständig dargestellt wird. Der Rest befindet sich in einem
    ///anderen Dokument. Jedes Form erbt von der Klasse FORM, welche sämtliche Funktionen eines Fensters zur Verfügung stellt
    public partial class Form1 : Form
    {
        //Konstruktor des Forms (wird bei Aufruf des Fensters aufgerufen)
        public Form1()
        {
            //Mit dieser Methode werden die Designerseitig gebauten Elemente gezeichnet
            InitializeComponent();

            //EVENTs sind spezielle Delegates, welche nicht per Zuweisung überschrieben werden können. Methode müssen das Event per += abbonieren und
            ///per -= deabbonieren. Tritt ein Event auf (z.B. wenn ein Button geklickt wird) werden alle Methoden ausgeführt, welche dieses Event
            ///abboniert haben
            btnKlickMich.Click += btnKlickMich_Click_2;
        }

        //Click-Methoden, der einzelnen Buttons
        private void btnKlickMich_Click(object sender, EventArgs e)
        {
            //Farbwechsel (this bezieht sich auf die aktuelle Klasse, d.h. dieses Fenster)
            this.BackColor = Color.LightPink;

            //Start des Timers
            timer1.Start();
        }

        private void btnKlickMich_Click_2(object sender, EventArgs e)
        {
            //Ändern der Text-Eigenschaft des Buttons (sender ist das Element, welches das Event ausgelöst hat)
            if (sender is Button)
                (sender as Button).Text = "Du hast geklickt";
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Stoppen des Timers
            timer1.Stop();

            //Schließen dieses Fensters (wenn dies das letzte Fenster der Applikation ist, beendet sich diese)
            this.Close();

            //Schließen der ganzen Applikation (inkl. aller offenen Fenster)
            Application.Exit();
        }

        private void neuesFenstersÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Öffnen eines weiteren Fensters
            Form1 neuesFenster = new Form1();
            neuesFenster.Text = "2. Fenster";

            neuesFenster.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aufruf einer MessageBox und Abfrage der Wahl des Benutzers
            if (MessageBox.Show("Fühlst du dich wohl?", "Befindlichkeitsnachfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("Toll. "+tbxInput.Text);
            }
            else
            {
                MessageBox.Show("Schade");
            }
        }

        //Methode, welche von dem Timer ausgeführt wird
        private void timer1_Tick(object sender, EventArgs e)
        {
            btnKlickMich.Left += 50;
        }
    }
}
