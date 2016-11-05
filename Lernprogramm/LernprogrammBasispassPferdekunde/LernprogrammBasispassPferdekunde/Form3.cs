using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LernprogrammBasispassPferdekunde
{
    public partial class Form3 : Form
    {
        string Ueberschrift = "Das Lernprogramm besteht aus zwei Teilen, einem Multiple-Choice-Test und einem Lernspiel.";

        string UeM = "Multiple-Choice-Test: ";
        string Multiple = "Nach einem Klick auf 'Start' beginnt der Multiple-Choice-Test. Per Zufallsprinzip wird eine Frage und " +
                           "drei Antwortalternativen angezeigt. Außerdem wird ein zur Frage passendes Bild angezeigt. Zusätzlich können " +
                           "Frage und Antwortalternativen nach einem Klick auf das Audio-Symbol angehört werden. Der Button 'Antwort prüfen' " +
                           "kann erst angeklickt werden, wenn eine Antwort ausgewählt wurde und zeigt an, ob die Antwort stimmt oder nicht. " +
                           "Wenn die Antwort falsch ist wird die richtige Antwort angezeigt und die Frage bleibt im Spiel. Wenn die richtige " +
                           "Antwort gegeben wurde wird die Frage aus dem aktuellen Spiel genommen. Wenn alle Fragen richtig beantwortet wurden " +
                           "ist der Multiple-Choice-Test vorbei.";

        string UeL = "Lernspiel: ";
        string Lernspiel = "Das Lernspiel funktioniert ähnlich wie ein Memory, jedoch sollen hier die zusammengehörigen Frage- und Antwort-Paare " +
                           "gefunden werden. Die ersten 10 Karten bestehen aus Fragen und die letzten 10 Karten beinhalten die Antworten. Es werden zwei Karten " +
                           "angeklickt und somit aufgedeckt. Wenn die Frage und Antwort zusammenpassen bleiben die Karten aufgedeckt liegen. Wenn Frage " +
                           "und Antwort nicht zusammenpassen, dann werden die Karten nach kurzer Zeit wieder verdeckt. " +
                           "Das Spiel ist zu Ende sobald alle Frage- und Antwortpaare gefunden wurden.";

                           

        public Form3()
        {
            InitializeComponent();
            lblUeberschrift.Text = Ueberschrift;
            lblUeM.Text = UeM;
            lblMultiple.Text = Multiple;
            lblUeL.Text = UeL;
            lblLernspiel.Text = Lernspiel;
        }       
        
    }
}
