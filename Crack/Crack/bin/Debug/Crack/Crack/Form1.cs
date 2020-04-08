using System;
using System.Windows.Forms;

namespace Crack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //userControldownload1.BackColor= Color.FromArgb(90, 173, 173, 173);
            //userControlCrack1.BackColor= Color.FromArgb(90, 173, 173, 173);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
    }
}