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

        int G = 60; //G pour graviter
        int Force; //force de la graviter

        public MarioDojo()
        {
            InitializeComponent();
        }

        //------------------------------------------------------//

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (! clearX(player, Block1))
            {
                right = false;
                player.BackColor = System.Drawing.Color.Red;

            }
            else {
                player.BackColor = System.Drawing.Color.Pink;
            }

            if (right == true) { player.Left += 5; }
            if (left == true) { player.Left -= 5; }

            if (jump == true)
            {
                //falling if the player has jumped before 
                player.Top -= Force;
                Force -= 5;
            }


            if (player.Top + player.Height >= screen.Height)
            {
                player.Top = screen.Height - player.Height; //Stop falling at bottom
                jump = false;
            }
            else
            {
                player.Top += 5; //falling
            }


        }

        ///--------------------------------------------------///
        private void MarioDojo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right) { right = true; }
            if(e.KeyCode == Keys.Left) { left = true; }
            if(e.KeyCode == Keys.Escape) { this.Close(); } //Escape -> Exit l app

            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    Force = G;
                }
            }
        }

        private void Block1_Click(object sender, EventArgs e)
        {

        }

        private void MarioDojo_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right) { right = false; }
            if(e.KeyCode == Keys.Left ) { left = false; }
        }

        private bool clearX (System.Windows.Forms.PictureBox thing1, System.Windows.Forms.PictureBox thing2)
        {
            bool fullyLeft = thing1.Left < thing2.Left && thing1.Right < thing2.Left;
            bool fullyRight = thing1.Left > thing2.Right && thing1.Right > thing2.Right;
            return fullyLeft || fullyRight;
        }

        private bool clearY(System.Windows.Forms.PictureBox thing1, System.Windows.Forms.PictureBox thing2)
        {
            bool fullyTop = thing1.Top < thing2.Top && thing1.Bottom < thing2.Top;
            bool fullyBottom = thing1.Top > thing2.Bottom && thing1.Bottom > thing2.Bottom;
            return fullyTop || fullyBottom;
        }

    }
}
