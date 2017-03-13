using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiebzehnundVier
{
    class Ten : Card
    {
        public Ten(Image cardImage, Color color) : base(cardImage, color)
        {
            base.PointS = Points.Zehn;
        }
    }
}
