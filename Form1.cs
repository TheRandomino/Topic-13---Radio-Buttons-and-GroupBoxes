using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Topic_13___Radio_Buttons_and_GroupBoxes.Properties;

namespace Topic_13___Radio_Buttons_and_GroupBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radRedCheck(object sender, EventArgs e)
        {
            imgSaber.Image = Resources.red_lightsaber;
            radRed.Enabled = false;
            radGreen.Enabled = false;
            radioBlue.Enabled = false;
        }

        private void radGreenCheck(object sender, EventArgs e)
        {
            imgSaber.Image = Resources.green_lightsaber;
            radRed.Enabled = false;
            radGreen.Enabled = false;
            radioBlue.Enabled = false;
        }

        private void radBlueCheck(object sender, EventArgs e)
        {
            imgSaber.Image = Resources.blue_lightsaber;
            radRed.Enabled = false;
            radGreen.Enabled = false;
            radioBlue.Enabled = false;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (radEnterprise.Checked)
            {
                lblAnswer.Text = "Answer: Correct!";
                radEnterprise.Enabled = false;
                radMilleniumFalcon.Enabled = false;
                radTitanic.Enabled = false;
            }
            else if (radMilleniumFalcon.Checked)
            {
                lblAnswer.Text = "Answer: WROOOONG!";
                radEnterprise.Enabled = false;
                radMilleniumFalcon.Enabled = false;
                radTitanic.Enabled = false;
            }
            else if (radTitanic.Checked)
            {
                lblAnswer.Text = "Answer: WROOOONG!";
                radEnterprise.Enabled = false;
                radMilleniumFalcon.Enabled = false;
                radTitanic.Enabled = false;
            }
            else
            {
                lblAnswer.Text = "Answer: Please select an option";
            }
        }
    }
}
