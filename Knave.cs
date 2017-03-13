using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiebzehnundVier
{
    class Knave : Card
    {
        public Knave(Image cardImage, Color color) : base(cardImage, color)
        {
            base.PointS = Points.Bube;
        }
    }
}
