using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarioDojo
{
    public partial class MarioDojo : Form
    {
        bool right, left;
        bool jump;

        int G = 30; //G pour graviter
        int Force; //force de la graviter

        public MarioDojo()
        {
            InitializeComponent();
        }

        //Action part ------------------------------------------------------//

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(right == true) { player.Left += 5; }
            if (left == true) { player.Left -= 5; }

            if(jump == true)
            {
                //falling if the player has jumped before //Marche pas :(
                player.Top -= Force;
                Force -= 1;
            }
            if (player.Top + player.Height >= screen.Height)
            {
                player.Top = screen.Height - player.Height; //Stop falling at bottom
            }
            else
            {
                player.Top += 5; //falling
            }

           
        }

        /// Logique part --------------------------------------------------//
        private void MarioDojo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right) { right = true; }
            if(e.KeyCode == Keys.Left) { left = true; }
            if (e.KeyCode == Keys.Escape) { this.Close(); } //Escape -> Exit

            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    Force = G;
                }
            }
        }

        private void MarioDojo_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right) { right = false; }
            if(e.KeyCode == Keys.Left ) { left = false; }
        }
    }
}
