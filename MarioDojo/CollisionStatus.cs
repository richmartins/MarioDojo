using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioDojo
{
    class CollisionStatus
    {
        public bool canIncX = true;
        public bool canIncY = true;
        public bool canDecX = true;
        public bool canDecY = true;

        public int maxIncX = 5;
        public int maxDecX = 5;
        public int maxIncY = 1000;
        public int maxDecY = 1000;

        public static CollisionStatus contact(System.Windows.Forms.PictureBox player, System.Windows.Forms.PictureBox thing2)
        {
            CollisionStatus result = new CollisionStatus();
            bool fullyLeft = player.Left < thing2.Left && player.Right < thing2.Left;
            bool fullyRight = player.Left > thing2.Right && player.Right > thing2.Right;
            bool fullyTop = player.Top < thing2.Top && player.Bottom < thing2.Top;
            bool fullyBottom = player.Top > thing2.Bottom && player.Bottom > thing2.Bottom;

            if (fullyLeft || fullyRight || fullyTop || fullyBottom)
            {
                return result;
            }
            if(!fullyTop && !fullyBottom && player.Right >= thing2.Left)
            {
                result.canIncX = false;
            }

            if (!fullyTop && !fullyBottom && player.Left <= thing2.Right)
            {
                result.canDecX = false;
            }

            return result;
        }
    }

}
