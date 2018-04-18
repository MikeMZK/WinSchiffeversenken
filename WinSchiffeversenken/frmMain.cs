using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSchiffeversenken
{
    public partial class frmMain : Form
    {
        Spielfeld S;

        public frmMain()
        {
            InitializeComponent();

            S = new Spielfeld(pictureBox1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            S.Erstellen();
        }
    }
}
