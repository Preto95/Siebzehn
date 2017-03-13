using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SiebzehnundVier
{
    abstract class Card
    {
        public Image CardImage { protected set; get; }
        public Color Color { protected set; get; }
        public Points PointS { protected set; get; }

        public Card(Image cardImage, Color color)
        {
            this.CardImage = cardImage;
            this.Color = color;
        }



    }
}
