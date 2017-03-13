using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiebzehnundVier
{
    class King : Card
    {
        public King(Image cardImage, Color color) : base(cardImage, color)
        {
            base.PointS = Points.Zehn;
        }
    }
}
