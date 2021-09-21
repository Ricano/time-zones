using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace time_zones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDownMain.Value = 7;
            numericUpDownPrimeiro.Value = -1;
            numericUpDownSegundo.Value = -3;
            numericUpDownTerceiro.Value = -20;
        }

        /*
         * Edit menu open/close functionality.
         * on click changes the size of the app and makes sure it cannot be resized.
         */

        private bool isEditOpen = false;
        private const int MAX_WIDTH = 470;
        private const int MIN_WIDTH = 280;
        private const int HEIGHT = 256;
        private Size MIN_SIZE = new System.Drawing.Size(MIN_WIDTH, HEIGHT);
        private Size MAX_SIZE = new System.Drawing.Size(MAX_WIDTH, HEIGHT);
        

        private void label1_Click(object sender, EventArgs e)
        {
            if (isEditOpen)
            {
                MaximumSize = MIN_SIZE;
                MinimumSize = MIN_SIZE;
                Width = MIN_WIDTH;
                button.Text = ">>";
            }
            else
            {
                MaximumSize = MAX_SIZE;
                MinimumSize = MAX_SIZE;
                Width = MAX_WIDTH;
                button.Text = "<<";
            }
            isEditOpen = !isEditOpen;
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            // get local time and time given the difference in the edit menu
            
            TimeSpan diferMain = new TimeSpan((int)numericUpDownMain.Value, 0, 0);
            DateTime nowPortugal = DateTime.Now;
            DateTime nowIndia = nowPortugal+diferMain;

            // update the labels text
            portugal.Text = nowPortugal.ToString("HH:mm:ss");
            india.Text = nowIndia.ToString("HH:mm");

            // do the same for the other three labels
            TimeSpan diferPrimeiro = new TimeSpan((int)numericUpDownPrimeiro.Value, 0, 0);
            TimeSpan diferSegundo = new TimeSpan((int)numericUpDownSegundo.Value, 0, 0);
            TimeSpan diferTerceiro = new TimeSpan((int)numericUpDownTerceiro.Value, 0, 0);

            primeiro.Text = (nowIndia + diferPrimeiro).ToString("HH:mm");
            segundo.Text = (nowIndia + diferSegundo).ToString("HH:mm");
            terceiro.Text = (nowIndia + diferTerceiro).ToString("HH:mm");

            // update label text making sure singular and plural values remain text coeherent
            
            labelPrimeiro.Text = (numericUpDownPrimeiro.Value >= 0 ? "+ " : "") + (numericUpDownPrimeiro.Value) + " HORA" + ((numericUpDownPrimeiro.Value == 1 || numericUpDownPrimeiro.Value == -1)?"":"S");
            labelSegundo.Text = (numericUpDownSegundo.Value >= 0 ? "+ " : "") + (numericUpDownSegundo.Value) + " HORA" + ((numericUpDownSegundo.Value == 1 || numericUpDownSegundo.Value == -1)?"":"S");
            labelTerceiro.Text = (numericUpDownTerceiro.Value >= 0 ? "+ " : "") + (numericUpDownTerceiro.Value) + " HORA" + ((numericUpDownTerceiro.Value == 1 || numericUpDownTerceiro.Value == -1)?"":"S");

        }
    }
}
