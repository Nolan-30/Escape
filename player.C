using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cube2DMove
{
    public partial class Form1 : Form
    {
        // Propriétés du carré (notre "cube" en 2D)
        private int x = 100;
        private int y = 100;
        private int size = 50;
        private int speed = 10;

        public Form1()
        {
            // Paramètres de la fenêtre
            this.Text = "Mouvement 2D - Flèches Clavier";
            this.DoubleBuffered = true; // Évite les clignotements
            this.KeyDown += new KeyEventHandler(OnKeyDown);
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            // Déplacement horizontal
            if (e.KeyCode == Keys.Left) x -= speed;
            if (e.KeyCode == Keys.Right) x += speed;

            // Redessine la fenêtre pour voir le mouvement
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // On dessine un carré plat (2D)
            using (SolidBrush brush = new SolidBrush(Color.Blue))
            {
                g.FillRectangle(brush, x, y, size, size);
            }
        }
    }
}