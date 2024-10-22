using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_1
{
    internal class HighscoreList
    {
        #region Fields
        private static Score[] scores = new Score[10]; //Instanciates new array of type Score
        #endregion

        #region Properties
        /// <summary>
        /// Property for returning scores array (whole array)
        /// </summary>
        public static Score[] Scores
        {
            get { return scores; }
        }
        #endregion

        #region Methods (Functions)
        /// <summary>
        /// Places score object in scores array at index 0
        /// </summary>
        /// <param name="score">Score object</param>
        public static void AddScore(Score score)
        {
            scores[0] = score;
        }
        public static void PrintToScreen()
        {
            for (byte i = 0; i < scores.Length; i++)
            {
                if (scores[i] != null)
                {
                    Console.WriteLine(scores[i].Display());
                    break;
                }
            }
        }
        #endregion
    }
}
