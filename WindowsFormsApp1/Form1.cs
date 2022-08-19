using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int TimeLeft = 300;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = $"Today is {DateTime.Now:F}.";
            txtTimeLeft.Text = $"{TimeLeft} Seconds";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            txtAddenResult.Enabled = true;
            txtMinuendResult.Enabled = true;
            txtMultiplicandResult.Enabled = true;
            txtDividendResult.Enabled = true;

            ClearControls();

            GenerateTest();

            timer1.Start();
        }

        private void ClearControls()
        {
            if (TimeLeft != 300)
            {
                DialogResult dialogResult = MessageBox.Show("Estas Seguro que quieres empezar el otro examen?", "ALERTA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DefultControls();
                    return;
                }
            }

            DefultControls();
        }

        private void DefultControls()
        {
            TimeLeft = 300;

            lblAddend1.Text = "?";
            lblAddend2.Text = "?";

            lblMinuend1.Text = "?";
            lblMinuend2.Text = "?";

            lblMultiplicand1.Text = "?";
            lblMultiplicand2.Text = "?";

            lblDividend1.Text = "?";
            lblDividend1.Text = "?";

            txtTimeLeft.Text = $"{TimeLeft} Seconds";

            txtAddenResult.Text = "";
            txtMinuendResult.Text = "";
            txtMultiplicandResult.Text = "";
            txtDividendResult.Text = "";

            lblAddResult.Visible = false;
            lblMinuendResult.Visible = false;
            lblMultiplicandResult.Visible = false;
            lblDividendResult.Visible = false;
        }

        private void GenerateTest()
        {
            Random rnd = new Random();

            lblAddend1.Text = rnd.Next(1,99).ToString();
            lblAddend2.Text = rnd.Next(1, 99).ToString();
            
            lblMinuend1.Text = rnd.Next(1, 99).ToString();
            lblMinuend2.Text = rnd.Next(1, 99).ToString();
            
            lblMultiplicand1.Text = rnd.Next(1, 99).ToString();
            lblMultiplicand2.Text = rnd.Next(1, 99).ToString();
            
            lblDividend1.Text = rnd.Next(1, 99).ToString();
            lblDividend2.Text = rnd.Next(1, 99).ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Estas Seguro que quieres finalizar el examen?", "ALERTA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ValidateTest();
                btnStart.Enabled = true;
            }
        }

        private void ValidateTest()
        {
            //Validate Empty Fields
            if (string.IsNullOrEmpty(txtAddenResult.Text)) txtAddenResult.Text = "0";
            if (string.IsNullOrEmpty(txtMinuendResult.Text)) txtMinuendResult.Text = "0";
            if (string.IsNullOrEmpty(txtMultiplicandResult.Text)) txtMultiplicandResult.Text = "0";
            if (string.IsNullOrEmpty(txtDividendResult.Text)) txtDividendResult.Text = "0";

            //Adding Operation
            int addResult = int.Parse(lblAddend1.Text) + int.Parse(lblAddend2.Text);

            //Substract Operation
            int sust1 = int.Parse(lblMinuend1.Text);
            int sust2 = int.Parse(lblMinuend2.Text);
            int sustResult;
            if (sust1 < sust2)
            {
                sustResult = sust2 - sust1;
            }
            else
            {
                sustResult = sust1 - sust2;
            }

            //Multiplication Operation
            int multResult = int.Parse(lblMultiplicand1.Text) * int.Parse(lblMultiplicand2.Text);
            
            //Division Operation
            int divResult = int.Parse(lblDividend1.Text) / int.Parse(lblDividend2.Text);

            //Checking Results
            if (addResult == int.Parse(txtAddenResult.Text))
            {
                lblAddResult.Text = "√";
                lblAddResult.ForeColor = Color.Green;
            }
            else
            {
                lblAddResult.Text = "X";
                lblAddResult.ForeColor = Color.Red;
            }

            if (sustResult == int.Parse(txtMinuendResult.Text))
            {
                lblMinuendResult.Text = "√";
                lblMinuendResult.ForeColor = Color.Green;
            }
            else
            {
                lblMinuendResult.Text = "X";
                lblMinuendResult.ForeColor = Color.Red;
            }

            if (multResult == int.Parse(txtMultiplicandResult.Text))
            {
                lblMultiplicandResult.Text = "√";
                lblMultiplicandResult.ForeColor = Color.Green;
            }
            else
            {
                lblMultiplicandResult.Text = "X";
                lblMultiplicandResult.ForeColor = Color.Red;
            }

            if (divResult == int.Parse(txtDividendResult.Text))
            {
                lblDividendResult.Text = "√";
                lblDividendResult.ForeColor = Color.Green;
            }
            else
            {
                lblDividendResult.Text = "X";
                lblDividendResult.ForeColor = Color.Red;
            }

            //Endabled Result Control
            lblAddResult.Visible = true;
            lblMinuendResult.Visible = true;
            lblMultiplicandResult.Visible = true;
            lblDividendResult.Visible = true;

            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLeft--;
            txtTimeLeft.Text = $"{TimeLeft} Seconds";

            if (TimeLeft == 0)
            {
                MessageBox.Show("Se vencio el tiempo del examen", "EXAMEN FINALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                btnStart.Enabled = true;
                btnStop.Enabled = false;

                txtAddenResult.Enabled = false;
                txtMinuendResult.Enabled = false;
                txtMinuendResult.Enabled = false;
                txtDividendResult.Enabled = false;
            }
        }
    }
}
