using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            

        }

        decimal _mTotal = 0;
        ProjCodeHandler projHandlr = new ProjCodeHandler();
        /// <summary>
        /// Id�! Skapa en applikation/webbsida som r�knar ut hur m�nga timmar och minuter
        /// Som g�tt n�r man matar in klockslag under en dag och sedan efter avdrag 
        /// Av t ex. Lunch, r�knar ut vad som blir �ver. Teknik: Ta en ny s�som python f�r att l�ra sig.
	    /// � T ex. 08:00 - 09:15 + 10:15-13:00 + 15:00-17:00 (-lunch) == total antal timmar. 
	    /// � Man ska kunna l�gga till egna avdrag s�som vabb, FL eller sjukdom.
	    /// � Ev. visa Arbetskoder som kan �ndras och l�ggas till.
	    /// � Totalen ska visas och differensen (vad som �r egna arbetstiden och vad som �r tidsavdrag).

        /// </summary>
        /// TODO: Make total minutes work together with total hours and no hours, only minutes!  
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Klocka fr�n
            decimal h1 = numH1.Value;
            decimal h2 = numH2.Value;

            //Klocka till
            decimal h3 = numH3.Value;
            decimal h4 = numH4.Value;

            decimal timTot;
            decimal minTot;

            // 1. h1 (60 min) * antal timmar i minuter. 
            // 2. Sedan totala tiden blir sista klockslaget minus f�rsta klockslaget
            decimal timRes1 = h1 * 60;
            decimal timRes2 = h3 * 60;

            //Validering f�r att s�kerst�lla att "fr�n-klockan" �r mindre �n "till-klockan"
            if (timRes1 > timRes2)
            {
                MessageBox.Show("Fr�n-klockan f�r ej vara senare �n Till-klockan.", "Fel klockh�nvisning!", MessageBoxButtons.OK);
            }
            else
            {
                timTot = timRes2 - timRes1;

                // 1. h2 - h4 = antal minuter
                // 2. Sedan l�gga till minuterna p� den totala tiden
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

            //Create new instance of projCodeHandler and then new list instance to be able to add items.
            
            projHandlr.ProjectCodes = new List<string>();

            projHandlr.ProjectCodes.Add("P943103: Market Improvements.");
            projHandlr.ProjectCodes.Add("P943104: Market Field Quality Improvement.");
            projHandlr.ProjectCodes.Add("C100462: Line related activities.");
            projHandlr.ProjectCodes.Add("C100463: Education/Conferences.");

            //Add list to combobox
            cmbProjects.Items.AddRange(projHandlr.ProjectCodes.ToArray());
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            numH1.Focus();
        }

        private void btnAddProjHours_Click(object sender, EventArgs e)
        {
            double projHour = projHandlr.ProjCodeHours;
            bool valProjHour = double.TryParse(txtProjHours.Text, out projHour);
            if (!valProjHour)
            {
                MessageBox.Show("Only numbers aloud!");
            }
            else
            {
                projHandlr.TotProjCodeHours += projHour;
                projHandlr.ProjectHourPairs = new Dictionary<string, double>();
                projHandlr.ProjectHourPairs.Add(cmbProjects.Text, projHour);
                rchProjTotal.AppendText(cmbProjects.Text + " - " + projHour.ToString() + " hours.\n");
            }
                
            
        }

        private void btnAddCode_Click(object sender, EventArgs e)
        {
            cmbProjects.Items.Add(txtAddProj.Text);
        }

        private void btnRmvSingle_Click(object sender, EventArgs e)
        {
            //TODO: Also remove from richtextbox!
            if (projHandlr.TotProjCodeHours!=0)
            {
                double dictValue = 0;
                bool getDictValue = projHandlr.ProjectHourPairs.TryGetValue(cmbProjects.Text, out dictValue);
                projHandlr.TotProjCodeHours -= dictValue;
                projHandlr.ProjectHourPairs.Remove(cmbProjects.Text);
                SendKeys.Send("DELETE");
            }
        }

        private void btnCalcToProjHours_Click(object sender, EventArgs e)
        {
            rchProjTotal.AppendText("\n\n******** Total Project hours: " + projHandlr.TotProjCodeHours.ToString() + " ********");
        }

        private void btnResetProjHours_Click(object sender, EventArgs e)
        {
            rchProjTotal.Clear();
            txtProjHours.Clear();
            projHandlr.ProjectHourPairs.Clear();
            projHandlr.TotProjCodeHours = 0;
            projHandlr.ProjectCodes.Clear();
        }
    }
}