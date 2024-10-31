using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_4
{
    internal class Score
    {
        #region Fields (AKA attributes)
        private string name;
        private int points;
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{name} - {points}";
        }
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
