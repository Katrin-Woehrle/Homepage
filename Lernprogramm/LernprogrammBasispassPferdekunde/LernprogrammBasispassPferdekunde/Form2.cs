using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace LernprogrammBasispassPferdekunde
{
    public partial class Form2 : Form
    {
        //firstClicked zeigt auf das erste Label, das der Spieler anklickt
        //und ist null solange der Spieler noch nicht geklickt hat.
        Label firstClicked = null;

        //secondClicked zeigt auf das zweite Label, das der Spieler anklickt
        Label secondClicked = null;

        //Bnutze dieses Random Objekt um zufällige Symbole für die Felder auszuwählen
        Random random = new Random();

        // Jeder dieser Buchstaben ist ein interessantes Symbol in der Webdings-Schriftart
        // und jedes Symbol erscheint zweimal in der Liste!
        ArrayList FrageNummer = new ArrayList();

        ArrayList AWNummer = new ArrayList();

        ArrayList bildernamen = new ArrayList();

        ArrayList fragen = new ArrayList();

        ArrayList antworten = new ArrayList();

        string Zahl = "";

        string ZahlAW = "";

        string ErsterKlick = null;
        string SubstrErsterKlick = null;

        string ZweiterKlick = null;
        string SubstrZweiterKlick = null;

        private void Datenbank()
        {
            OleDbConnection verbindung = new OleDbConnection();
            OleDbCommand befehl = new OleDbCommand();
            OleDbDataReader reader;
                        
            verbindung.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                                          "Data Source=C:\\Temp\\FragenBachelor.mdb";

            befehl.Connection = verbindung;
            befehl.CommandText = "select * from Pferdeverhalten;";

            //fragen.Clear();
            //antworten.Clear();
            //ID.Clear();

            try
            {
                verbindung.Open();
                reader = befehl.ExecuteReader();

                while (reader.Read())
                {
                    FrageNummer.Add(reader["fragenummer"]);
                    AWNummer.Add(reader["fragenummer"]);
                    fragen.Add(reader["frage"]);
                    antworten.Add(reader["memAW"]);
                }

                reader.Close();
                verbindung.Close();

                }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }        

        /// <summary> 
        /// Ordnet jeden Text aus der Frage-Antwort-Liste einem zufälligen Feld zu
        /// </summary> 
        private void AssignIconsToSquares()
        {
            // Das TableLayoutPanel hat 20 Labels und die Frage- und Antwort-Listen ergeben zusammen 20,
            // damit ein Text per Zufall aus der Liste gezogen und jedem Label hinzugefügt werden kann.

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {                      
                    if (antworten.Count > 0)
                    {
                        int randomAW = random.Next(antworten.Count);
                        string NameAW = antworten[randomAW].ToString();

                        ZahlAW = AWNummer[randomAW].ToString();   
                        iconLabel.Text = ZahlAW + "." + NameAW;
                        iconLabel.ForeColor = iconLabel.BackColor;

                        antworten.RemoveAt(randomAW);                        
                        AWNummer.RemoveAt(randomAW);                        
                    }

                    else if (fragen.Count > 0)
                    {
                        int randomNumber = random.Next(fragen.Count);
                        string Name = fragen[randomNumber].ToString();

                        Zahl = FrageNummer[randomNumber].ToString();
                        iconLabel.Text = Zahl + "." + Name;
                        iconLabel.ForeColor = iconLabel.BackColor;

                        fragen.RemoveAt(randomNumber);
                        FrageNummer.RemoveAt(randomNumber);
                    }
                }
            }
        } 


        public Form2()
        {
            InitializeComponent();
            Datenbank();
            AssignIconsToSquares();           
        }

        /// <summary> 
        /// Jedes Label Click Event wird von diesem event-handler verarbeitet.
        /// </summary> 
        /// <param name="sender">Das Label wurde angeklickt.</param>
        /// <param name="e"></param>
        private void label_Click(object sender, EventArgs e)
        {
            // Der Timer ist nur an sobald dem Spieler zwei nicht zusammenpassende Karten angezeigt werden
            // so werden alle Klicks ignoriert wenn der Timer läuft.
            if (timer1.Enabled == true)
                return; 
            
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // Wenn das angeklickte Label schwarz ist, hat der Spieler auf eine Karte geklickt,
                // die schon aufgedeckt ist, ignoriere diesen Klick.
                if (clickedLabel.ForeColor == Color.Black)
                    // Alles erledigt - verlasse den if-Block.
                    return;

                // Wenn firstClicked null ist, ist dies die erste Karte des Paares das der Spieler anklickt,
                // setze also firstClicked auf das Label das der Spieler angeklickt hat, ändere seine Farbe auf Schwarz
                // und gehe zurück.
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;                   

                    // Alles erledigt, verlasse den if-Block
                    return;
                }

                // Wenn der Spieler so weit gekommen ist, der Timer läuft nicht und firstClicked ist nicht null,
                // muss dies die zweite Karte sein, das der Spieler anklickt. Setze seine Farbe auf Schwarz.
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                // Prüfen, um zu sehen ob der Spieler gewonnen hat.
                CheckForWinner();
                
                // Wenn der Spieler zwei zusammenpassende Karten angeklickt hat lasse sie schwarz
                // und setze firstClicked und secondClicked zurück, damit der Spieler eine neue Karte anklicken kann.                        

                try
                {
                    int startIndex = 0;
                    int length = 2;
                    ErsterKlick = firstClicked.Text;
                    SubstrErsterKlick = ErsterKlick.Substring(startIndex, length);
                    ZweiterKlick = secondClicked.Text;
                    SubstrZweiterKlick = ZweiterKlick.Substring(startIndex, length);

                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                   
                }

                    if (SubstrErsterKlick == SubstrZweiterKlick)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                // Wenn der Spieler so weit gekommen ist, hat der Spieler zwei verschiedene Karten angeklickt,
                // starte also den Timer (dieser wartet eine dreiviertel Sekunde und verdeckt dann die Karten).
                timer1.Start();
            }
        }

        /// <summary> 
        /// Dieser Timer wird gestartet wenn der Spieler zwei Karten anklickt, die nicht zusammenpassen,
        /// er zählt also eine dreiviertel Sekunde und schaltet sich dann selbst ab und verdeckt beide Karten
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stoppe den Timer.
            timer1.Stop();

            // Verdecke beide Symbole.
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Setze firstClicked und secondClicked zurück,
            // damit das Programm beim nächsten Klick auf ein Label weiß, dass es der erste Klick ist.
            firstClicked = null;
            secondClicked = null;
        }

        /// <summary> 
        /// Überprüfe jede Karte um zu sehen ob Frage und Antwort übereinstimmen, indem deren
        /// Vordergrund-Farbe mit deren Hintergrundfarbe verglichen wird.
        /// Wenn alle Karten übereinstimmen hat der Spieler gewonnen.
        /// </summary> 
        private void CheckForWinner()
        {
            // Gehe durch alle Labels im TableLayoutPanel,
            // prüfe jedes einzelne um zu sehen ob dessen Frage und Antwort zusammenpasst.
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            // Wenn die Schleife nicht zurückkehrt, findet es keine nicht-passende Karten.
            // Das heisst dass der Spieler gewonnen hat.
            // Zeige eine Nachricht und schließe das Formular.
            MessageBox.Show("Du hast alle Paare gefunden!", "Gratulation!");
            Close();
        }
    }
}
