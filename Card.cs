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
        protected Image cardImage;   //object for the Card-View

        public Card(Image cardImage)
        {
            this.cardImage = cardImage;
        }
        
        public Image CardImage
        {
            private set { cardImage = value; }
            get { return cardImage; }
        }
    }
}
