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
using System.Media;

namespace LernprogrammBasispassPferdekunde
{
    public partial class Form1 : Form
    {
        ArrayList ID = new ArrayList();
        ArrayList Frage = new ArrayList();
        ArrayList AWA = new ArrayList();
        ArrayList AWB = new ArrayList();
        ArrayList AWC = new ArrayList();
        ArrayList bildname = new ArrayList();
        ArrayList audiodatei = new ArrayList();

        private SoundPlayer player = new SoundPlayer();

        /* Zufallszahl für Antwortreihenfolge */
        int AWzufallszahl;

        /*Zufallszahl für ein Element der beiden Listen */
        int zufallszahl;

        /*Erzeugen und initialisieren des Zufallsgenerators */
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
            rBAntwort1.Visible = false;
            rBAntwort2.Visible = false;
            rBAntwort3.Visible = false;
            lblFrageNummer.Visible = false;
            lblFrageID.Visible = false;
            lblFrage.Visible = false;
            pBBild.Visible = false;
            btnaudio.Visible = false;
            btnAwPruefen.Visible = false;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rBAntwort1.Checked = false;
            pBEndbild.Visible = false;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader;

            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                                   "Data Source=C:\\Temp\\FragenBachelor.mdb";

            cmd.Connection = con;
            cmd.CommandText = "select * from Pferdeverhalten;";

            ID.Clear();
            Frage.Clear();
            AWA.Clear();
            AWB.Clear();
            AWC.Clear();
            bildname.Clear();
            audiodatei.Clear();

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ID.Add(reader["ID"]);
                    Frage.Add(reader["frage"]);
                    AWA.Add(reader["antwort1"]);
                    AWB.Add(reader["antwort2"]);
                    AWC.Add(reader["antwort3"]);
                    bildname.Add(reader["bildname"]);
                    audiodatei.Add(reader["audio"]);
                }

                reader.Close();
                con.Close();

                rBAntwort1.Visible = true;
                rBAntwort2.Visible = true;
                rBAntwort3.Visible = true;
                lblFrageNummer.Visible = true;
                lblFrageID.Visible = true;
                lblFrage.Visible = true;
                pBBild.Visible = true;
                btnaudio.Visible = true;
                btnAwPruefen.Visible = true;
                btnAwPruefen.Enabled = false;

                NaechsteFrage();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NaechsteFrage()
        {
            /*Falls keine Frage mehr in der Liste: Ende */
            if (Frage.Count < 1)
            {
                Test_Init();
                pBEndbild.Visible = true;
                MessageBox.Show("Gratuliere! Alles geschafft");
            }

            /*Falls noch Fragen in der Liste: Nächste */
            else
            {
                startToolStripMenuItem.Enabled = false;
                zufallszahl = r.Next(0, Frage.Count);

                lblFrageID.Text = "" + ID[zufallszahl] + " :";
                lblFrage.Text = "" + Frage[zufallszahl];

                AWzufallszahl = r.Next(0, 2);

                if (AWzufallszahl == 0)
                {
                    rBAntwort1.Text = "" + AWA[zufallszahl];
                    rBAntwort2.Text = "" + AWB[zufallszahl];
                    rBAntwort3.Text = "" + AWC[zufallszahl];
                }

                else if (AWzufallszahl == 1)
                {
                    rBAntwort1.Text = "" + AWB[zufallszahl];
                    rBAntwort2.Text = "" + AWC[zufallszahl];
                    rBAntwort3.Text = "" + AWA[zufallszahl];
                }

                else if (AWzufallszahl == 2)
                {
                    rBAntwort1.Text = "" + AWC[zufallszahl];
                    rBAntwort2.Text = "" + AWA[zufallszahl];
                    rBAntwort3.Text = "" + AWB[zufallszahl];
                }

                object o = Properties.Resources.ResourceManager.GetObject(bildname[zufallszahl].ToString());

                pBBild.Image = (Image)o;
            }
        }

        private void Test_Init()
        {
            /*Start-Button wieder nutzbar machen*/
            startToolStripMenuItem.Enabled = true;

            /*Felder leeren */
            lblFrage.Text = "";
            lblFrageID.Text = "";

            /*Felder unsichtbar machen */
            lblFrageID.Visible = false;
            lblFrageNummer.Visible = false;
            lblFrage.Visible = false;
            rBAntwort1.Visible = false;
            rBAntwort2.Visible = false;
            rBAntwort3.Visible = false;
            btnAwPruefen.Visible = false;
            pBBild.Visible = false;
            btnaudio.Visible = false;
        }



        private void btnAwPruefen_Click(object sender, EventArgs e)
        {
            //player = new System.Media.SoundPlayer(Properties.Resources.ResourceManager.GetStream(audiodatei[zufallszahl].ToString()));
            player.Stop();

            /* Falls rbAntwort1 ausgewählt wurde */
            if (rBAntwort1.Checked == true)
            {
                if (rBAntwort1.Text == AWA[zufallszahl].ToString())
                {
                    /*Falls richtig beantwortet: Frage aus der Liste nehmen*/
                    MessageBox.Show("Richtig", "Frage");
                    ID.RemoveAt(zufallszahl);
                    Frage.RemoveAt(zufallszahl);
                    AWA.RemoveAt(zufallszahl);
                    AWB.RemoveAt(zufallszahl);
                    AWC.RemoveAt(zufallszahl);
                    bildname.RemoveAt(zufallszahl);
                    audiodatei.RemoveAt(zufallszahl);
                }
                else
                {
                    /*Falls falsch beantwortet: richtige Antwort nennen */
                    MessageBox.Show("Falsch, richtige Antwort" + " ist\n'" + AWA[zufallszahl] + "'", "Antwort");
                }
            }

            /* Falls rbAntwort2 ausgewählt wurde */
            else if (rBAntwort2.Checked == true)
            {
                /*Falls richtig beantwortet: Frage aus der Liste nehmen*/
                if (rBAntwort2.Text == AWA[zufallszahl].ToString())
                {
                    MessageBox.Show("Richtig", "Frage");
                    ID.RemoveAt(zufallszahl);
                    Frage.RemoveAt(zufallszahl);
                    AWA.RemoveAt(zufallszahl);
                    AWB.RemoveAt(zufallszahl);
                    AWC.RemoveAt(zufallszahl);
                    bildname.RemoveAt(zufallszahl);
                    audiodatei.RemoveAt(zufallszahl);
                }
                else
                {
                    /*Falls falsch beantwortet: richtige Antwort nennen */
                    MessageBox.Show("Falsch, richtige Antwort" + " ist\n'" + AWA[zufallszahl] + "'", "Antwort");
                }
            }

           /* Falls rbAntwort3 ausgewählt wurde */
            else if (rBAntwort3.Checked == true)
            {
                /*Falls richtig beantwortet: Frage aus der Liste nehmen*/
                if (rBAntwort3.Text == AWA[zufallszahl].ToString())
                {
                    MessageBox.Show("Richtig", "Frage");
                    ID.RemoveAt(zufallszahl);
                    Frage.RemoveAt(zufallszahl);
                    AWA.RemoveAt(zufallszahl);
                    AWB.RemoveAt(zufallszahl);
                    AWC.RemoveAt(zufallszahl);
                    bildname.RemoveAt(zufallszahl);
                    audiodatei.RemoveAt(zufallszahl);
                }
                else
                {
                    /*Falls falsch beantwortet: richtige Antwort nennen */
                    MessageBox.Show("Falsch, richtige Antwort" + " ist\n'" + AWA[zufallszahl] + "'", "Antwort");
                }
            }

            NaechsteFrage();
        }

        private void rBAntwort1_Click(object sender, EventArgs e)
        {
            btnAwPruefen.Enabled = true;
        }

        private void rBAntwort2_Click(object sender, EventArgs e)
        {
            btnAwPruefen.Enabled = true;
        }

        private void rBAntwort3_Click(object sender, EventArgs e)
        {
            btnAwPruefen.Enabled = true;
        }

        private void btnaudio_Click(object sender, EventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.ResourceManager.GetStream(audiodatei[zufallszahl].ToString()));
            player.Play();
        }

        private void spielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 spiel = new Form2();
            spiel.Show();
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 hilfe = new Form3();
            hilfe.Show();
        }

        private void beendenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

