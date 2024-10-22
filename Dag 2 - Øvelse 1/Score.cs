using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_1
{
    internal class Score
    {
        #region Fields (AKA attributes)
        //Are not read- or write-able outside of this class. Means HighscoreList cannot read Score values (without adding public property to get score values)
        private string name;
        private int points;
        #endregion

        #region Constructors
        public Score(string name, int points)
        {
            this.name = name;
            this.points = points;
        }
        #endregion
    }
}
