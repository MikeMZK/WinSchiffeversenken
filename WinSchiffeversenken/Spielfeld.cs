using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinSchiffeversenken
{
    class Spielfeld
    {
        private int felderanzahl = 10;
        private int boxsize = 40;
        public PictureBox[,] Felder = new PictureBox[10, 10];

        private PictureBox pb;

        public Spielfeld(PictureBox pb)
        {
            this.pb = pb;
        }

        public void Erstellen()
        {
            pb.BackColor = Color.Black;
            pb.Height = boxsize * felderanzahl + boxsize + 1;
            pb.Width = boxsize * felderanzahl + boxsize + 1;

            Felder[0, 0] = new PictureBox();
            Felder[0, 0].BackColor = Color.Gray;
            Felder[0, 0].Width = boxsize;
            Felder[0, 0].Height = boxsize;

        }





    }
}
