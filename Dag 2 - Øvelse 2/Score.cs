using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_2
{
    internal class Score
    {
        #region Fields (AKA attributes)
        private string name;
        private int points;
        #endregion

        #region Methods
        public string Display()
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
