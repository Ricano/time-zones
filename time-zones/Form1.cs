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
            }
            else
            {
                MaximumSize = MAX_SIZE;
                MinimumSize = MAX_SIZE;
                Width = MAX_WIDTH;
            }
            isEditOpen = !isEditOpen;
        }



    }
}
