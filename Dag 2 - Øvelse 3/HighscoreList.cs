﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_3
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
        /// Places score object in scores array at first empty cell, until the end of the array is reached
        /// </summary>
        /// <param name="score">Score object</param>
        public static void AddScore(Score score)
        {
            for (byte i = 0; i < scores.Length; i++)
            {
                if (scores[i] == null)
                {
                    scores[i] = score;
                    break;
                }
            }
        }
        /// <summary>
        /// Displays all values in array if they are not null. Also checks if there is more room in array
        /// </summary>
        /// <returns>True if the array is full</returns>
        public static bool PrintToScreen()
        {
            bool arrayFull = false;

            if (scores[scores.Length - 1] != null)
            {
                Console.WriteLine("Cannot store more scores");

                arrayFull = true;
            }

            for (byte i = 0; i < scores.Length; i++)
            {
                if (scores[i] != null)
                {
                    Console.WriteLine(scores[i].Display());
                }
            }

            return arrayFull;
        }
        #endregion
    }
}
