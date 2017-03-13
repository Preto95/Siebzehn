using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiebzehnundVier
{
    class Ass : Card
    {
        public Ass(Image cardImage, Color color) : base(cardImage, color)
        {
            base.PointS = Points.Ass;
        }
    }
}
