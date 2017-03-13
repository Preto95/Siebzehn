using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiebzehnundVier
{
    class Eight : Card
    {
        public Eight(Image cardImage, Color color, Points points) : base(cardImage, color)
        {
            base.PointS = Points.Acht;
        }
    }
}
