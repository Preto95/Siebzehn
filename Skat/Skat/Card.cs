using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SiebzehnundVier
{
    class Card
    {
        public Image CardImage { protected set; get; }
        public Color Color { protected set; get; }
        public Points PointS { protected set; get; }

        public Card(Image cardImage, Color color)
        {
            this.CardImage = cardImage;
            this.Color = color;
        }

        /// <summary>
        /// Randomize the objects of a list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static List<T> Shuffle<T>(List<T> list)
        {
            Random rand = new Random();

            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return list;
        }

        /// <summary>
        /// Count the Points
        /// </summary>
        /// <param name="deck0"></param>
        /// <returns></returns>
        public static int[] CompareDecks(params Card[] deck0)
        {
            int[] pointsofDecks = new int[4] { 0, 0, 0, 0 };

            #region Counting Points

            #endregion

        }
    }
