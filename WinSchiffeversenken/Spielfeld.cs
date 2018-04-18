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
        private Form frm;

        public Spielfeld(PictureBox pb, Form frm, int boxsize)
        {
            this.pb = pb;
            this.frm = frm;
            this.boxsize = boxsize;

            BoxEigenschaften();
        }

        public void Erstellen()
        {
            pb.BackColor = Color.Black;
            pb.Height = boxsize * felderanzahl + felderanzahl + 1;
            pb.Width = boxsize * felderanzahl + felderanzahl + 1;


            foreach (var item in Felder)
            {
                frm.Controls.Add(item);
                item.BringToFront();
                item.MouseHover += Item_MouseHover;
            }

            int x = pb.Location.X + 1, y = pb.Location.Y + 1;

            for (int i = 0; i < Felder.GetLength(0); i++)
            {
                for (int l = 0; l < Felder.GetLength(1); l++)
                {
                    Felder[i, l].Location = new Point(x, y);
                    x += boxsize + 1;
                }
                x = pb.Location.X + 1;
                y += boxsize + 1;
            }

        }

        private void Item_MouseHover(object sender, EventArgs e)
        {
            PictureBox PB = (PictureBox)sender;
            PB.BackColor = Color.Red;
        }

        private void BoxEigenschaften()
        {
            for (int i = 0; i < Felder.GetLength(0); i++)
            {
                for (int x = 0; x < Felder.GetLength(1); x++)
                {
                    Felder[i, x] = new PictureBox();
                    Felder[i, x].BackColor = Color.Orange;
                    Felder[i, x].Width = boxsize;
                    Felder[i, x].Height = boxsize;
                }
            }

        }



    }
}
