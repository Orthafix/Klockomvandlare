using System;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal _mTotal = 0;

        /// <summary>
        /// Idè! Skapa en applikation/webbsida som räknar ut hur många timmar och minuter
        /// Som gått när man matar in klockslag under en dag och sedan efter avdrag 
        /// Av t ex. Lunch, räknar ut vad som blir över. Teknik: Ta en ny såsom python för att lära sig.
	    /// • T ex. 08:00 - 09:15 + 10:15-13:00 + 15:00-17:00 (-lunch) == total antal timmar. 
	    /// • Man ska kunna lägga till egna avdrag såsom vabb, FL eller sjukdom.
	    /// • Ev. visa Arbetskoder som kan ändras och läggas till.
	    /// • Totalen ska visas och differensen (vad som är egna arbetstiden och vad som är tidsavdrag).

        /// </summary>
        /// TODO: Make total minutes work together with total hours and no hours, only minutes!  
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Klocka från
            decimal h1 = numH1.Value;
            decimal h2 = numH2.Value;

            //Klocka till
            decimal h3 = numH3.Value;
            decimal h4 = numH4.Value;

            decimal timTot;
            decimal minTot;

            // 1. h1 (60 min) * antal timmar i minuter. 
            // 2. Sedan totala tiden blir sista klockslaget minus första klockslaget
            decimal timRes1 = h1 * 60;
            decimal timRes2 = h3 * 60;

            //Validering för att säkerställa att "från-klockan" är mindre än "till-klockan"
            if (timRes1 > timRes2)
            {
                MessageBox.Show("Från-klockan får ej vara senare än Till-klockan.", "Fel klockhänvisning!", MessageBoxButtons.OK);
            }
            else
            {
                timTot = timRes2 - timRes1;

                // 1. h2 - h4 = antal minuter
                // 2. Sedan lägga till minuterna på den totala tiden
                minTot = h4 - h2;

                timTot = timTot + minTot;

                // Adderar till globala variabeln _mTotal
                _mTotal = _mTotal + timTot;

                rchTotal.AppendText(timTot.ToString() + " min" + "\r");
            }

        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            numH1.ResetText();
            numH2.ResetText();
            numH3.ResetText();
            numH4.ResetText();
            chkLun.Checked = false;
            numLun.ResetText();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnCalculate.Enabled = false;
            decimal lunchTid = numLun.Value;
            decimal totMin = _mTotal;
            if (chkLun.Checked)
            {
                totMin = totMin - lunchTid;
            }
            decimal totTimMin = Math.Round((totMin / 60), 2);


            string HM = totTimMin.ToString();
            double checkInteger = double.Parse(HM);
            //If no minutes then add ",0" for the splitter
            if (checkInteger % 1 == 0)
            {
                HM += ",0";
            }

            string[] hourSplitter = HM.Split(','); //splittar mellan timmar och minuter
            string hundredsToSixties = "0," + hourSplitter[1].ToString();

            //A variable that should handle if minutes has pre-tracing zeros
            string preZeroInMinCheckString = hourSplitter[1].ToString();

            //If second decimal has 0 prefix - remove zero
            if (preZeroInMinCheckString.StartsWith("0"))
            {
                hundredsToSixties.Remove(0, 1);
            }

            double MinSixty = double.Parse(hundredsToSixties) * 60;
            double roundMinSixty = Math.Round(MinSixty);
            double HMToClock = double.Parse(hourSplitter[0]);


            if (chkLun.Checked)
            {
                rchTotal.AppendText(" ****** " + HMToClock.ToString() + "," + roundMinSixty.ToString() + " hours incl. lunch ******" + "\r");
            }
            else
                rchTotal.AppendText(" ****** " + HMToClock.ToString() + "," + roundMinSixty.ToString() + " hours excl. lunch ******" + "\r");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            btnCalculate.Enabled = true;
            rchTotal.ResetText();
            numH1.Value = 7;
            numH2.Value = 30;
            numH3.Value = 16;
            numH4.Value = 15;
            numLun.Value = 45;
            chkLun.Checked = true;
            _mTotal = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numH1.Value = 7;
            numH2.Value = 30;
            numH3.Value = 16;
            numH4.Value = 15;
            numLun.Value = 45;
            chkLun.Checked = true;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            numH1.Focus();
        }
    }
}