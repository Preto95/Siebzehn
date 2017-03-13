using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiebzehnundVier
{
    static class CardFunctions
    {
        public static void Shuffle<T>(List<T> list)
        {
            Random rand = new Random();

            int n = list.Count;

            while(n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static int[] CompareDecks(List<Card> deck0, List<Card> deck1, List<Card> deck2, List<Card> deck3)
        {
            int[] pointsofDecks = new int[4] { 0, 0, 0, 0 };

            #region Counting Points
            foreach (Card c in deck0)
            {
                pointsofDecks[0] += (int)c.PointS;
            }
            foreach (Card c in deck1)
            {
                pointsofDecks[1] += (int)c.PointS;
            }
            foreach (Card c in deck2)
            {
                pointsofDecks[2] += (int)c.PointS;
            }
            foreach (Card c in deck3)
            {
                pointsofDecks[3] += (int)c.PointS;
            }
            #endregion

            

        }
    }
}
