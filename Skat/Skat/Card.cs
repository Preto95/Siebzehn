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
        /// <typeparam name="T">Datatype</typeparam>
        /// <param name="list">A list of objects</param>
        /// <returns>Returns a radomized list</returns>
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
        /// <param name="deck0">Deck of Player 1</param>
        /// <param name="deck1">Deck of Player 2</param>
        /// <returns>Returns a sorted list of points per deck</returns>
        public static List<int> CompareDecks(List<Card> deck0, List<Card> deck1)
        {
            List<int> pointsofDecks = new List<int>(4);

            #region Counting Points
            foreach (Card card in deck0)
            {
                pointsofDecks.Add((int)card.PointS);
            }
            foreach (Card card in deck1)
            {
                pointsofDecks.Add((int)card.PointS);
            }
            #endregion

            pointsofDecks.Sort();

            return pointsofDecks;
        }

        /// <summary>
        /// Count the Points
        /// </summary>
        /// <param name="deck0">Deck of Player 1</param>
        /// <param name="deck1">Deck of Player 2</param>
        /// <param name="deck2">Deck of Player 3</param>
        /// <returns>Returns a sorted list of points per deck</returns>
        public static List<int> CompareDecks(List<Card> deck0, List<Card> deck1, List<Card> deck2)
        {
            List<int> pointsofDecks = new List<int>(4);

            #region Counting Points
            foreach (Card card in deck0)
            {
                pointsofDecks.Add((int)card.PointS);
            }
            foreach (Card card in deck1)
            {
                pointsofDecks.Add((int)card.PointS);
            }
            foreach (Card card in deck2)
            {
                pointsofDecks.Add((int)card.PointS);
            }
            #endregion

            pointsofDecks.Sort();

            return pointsofDecks;
        }

        /// <summary>
        /// Count the Points
        /// </summary>
        /// <param name="deck0">Deck of Player 1</param>
        /// <param name="deck1">Deck of Player 2</param>
        /// <param name="deck2">Deck of Player 3</param>
        /// <param name="deck3">Deck of Player 4</param>
        /// <returns>Returns a sorted list of points per deck</returns>
        public static List<int> CompareDecks(List<Card> deck0, List<Card> deck1, List<Card> deck2, List<Card> deck3)
        {
            List<int> pointsofDecks = new List<int>(4);

            #region Counting Points
            foreach (Card card in deck0)
            {
                pointsofDecks.Add((int)card.PointS);
            }
            foreach (Card card in deck1)
            {
                pointsofDecks.Add((int)card.PointS);
            }
            foreach (Card card in deck2)
            {
                pointsofDecks.Add((int)card.PointS);
            }
            foreach (Card card in deck3)
            {
                pointsofDecks.Add((int)card.PointS);
            }
            #endregion

            pointsofDecks.Sort();

            return pointsofDecks;
        }

        //public void deinemudda(params Card[] tmp)
        //{
        //    tmp[0].lst.
        //}

        public static List<Card> GenerateDecks(int playerCount)
        {

        }
    }
}
