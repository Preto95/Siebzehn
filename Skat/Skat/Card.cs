using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace SiebzehnundVier
{
    class Card
    {
        public Image CardImage { protected set; get; }
        public Color Color { protected set; get; }
        public Points PointS { protected set; get; }

        public Card(Image cardImage, Points points, Color color)
        {
            this.CardImage = cardImage;
            this.PointS = points;
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

        public void LoadCards()
        {
            Settings.dic.Add(Skat.Properties.Resources.Cross_Eight);
            Settings.dic.Add(Skat.Properties.Resources.Cross_Jack);
            Settings.dic.Add(Skat.Properties.Resources.Cross_King);
            Settings.dic.Add(Skat.Properties.Resources.Cross_Nine);
            Settings.dic.Add(Skat.Properties.Resources.Cross_Queen);
            Settings.dic.Add(Skat.Properties.Resources.Cross_Seven);
            Settings.dic.Add(Skat.Properties.Resources.Cross_Ten);
            Settings.dic.Add(Skat.Properties.Resources.Diamond_Ass);
            Settings.dic.Add(Skat.Properties.Resources.Diamond_Eight);
            Settings.dic.Add(Skat.Properties.Resources.Diamond_Jack);
            Settings.dic.Add(Skat.Properties.Resources.Diamond_King);
            Settings.dic.Add(Skat.Properties.Resources.Diamond_Nine);
            Settings.dic.Add(Skat.Properties.Resources.Diamond_Queen);
            Settings.dic.Add(Skat.Properties.Resources.Diamond_Seven);
            Settings.dic.Add(Skat.Properties.Resources.Diamond_Ten);
            Settings.dic.Add(Skat.Properties.Resources.Heart_Ass);
            Settings.dic.Add(Skat.Properties.Resources.Heart_Eight);
            Settings.dic.Add(Skat.Properties.Resources.Heart_Jack);
            Settings.dic.Add(Skat.Properties.Resources.Heart_King);
            Settings.dic.Add(Skat.Properties.Resources.Heart_Nine);
            Settings.dic.Add(Skat.Properties.Resources.Heart_Queen);
            Settings.dic.Add(Skat.Properties.Resources.Heart_Seven);
            Settings.dic.Add(Skat.Properties.Resources.Heart_Ten);
            Settings.dic.Add(Skat.Properties.Resources.Piek_Ass);
            Settings.dic.Add(Skat.Properties.Resources.Piek_Eight);
            Settings.dic.Add(Skat.Properties.Resources.Piek_Jack);
            Settings.dic.Add(Skat.Properties.Resources.Piek_King);
            Settings.dic.Add(Skat.Properties.Resources.Piek_Nine);
            Settings.dic.Add(Skat.Properties.Resources.Piek_Queen);
            Settings.dic.Add(Skat.Properties.Resources.Piek_Seven);
            Settings.dic.Add(Skat.Properties.Resources.Piek_Ten);

            //public static List<Card> GenerateCards()
            //{
            //    List<Card> lstCards = new List<Card>(33);

            //    Directory.SetCurrentDirectory(@"..\..\Skat\Cards\Playing Cards\PNG-cards-1.3");

            //    int i = 2;
            //    while(i <= (int)Points.Ass)
            //    {
            //        int j = 0;
            //        while(j <= 3)
            //        {
            //            lstCards.Add(new Card(Color.ToString()))
            //        }

            //        if (i == 4)
            //            i += 3;
            //        else
            //            i++;
            //    }
            ////    lstCards.Add(new Card(Image.FromFile("Herz_Sieben.png"), Points.Seven, Color.Herz));
            ////    lstCards.Add(new Card(Image.FromFile("Karo_Sieben.png"), Points.Seven, Color.Karo));
            ////    lstCards.Add(new Card(Image.FromFile("Piek_Sieben.png"), Points.Seven, Color.Piek));
            ////    lstCards.Add(new Card(Image.FromFile("Kreuz_Sieben.png"), Points.Seven, Color.Kreuz));
            ////    lstCards.Add(new Card(Image.FromFile("Herz_Acht.png"), Points.Eight, Color.Herz));
            ////    lstCards.Add(new Card(Image.FromFile("Karo_Acht.png"), Points.Eight, Color.Karo));
            ////    lstCards.Add(new Card(Image.FromFile("Piek_Acht.png"), Points.Eight, Color.Piek));
            ////    lstCards.Add(new Card(Image.FromFile("Herz_Acht.png"), Points.Eight, Color.Herz));
            //}
        }
}
