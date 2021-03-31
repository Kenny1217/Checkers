using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Classes
{
    class PlayerModel
    {
        private string PlayerName;
        private string PlayerColor;

        public PlayerModel(string name, string color)
        {
            PlayerName = name; // Players Name
            PlayerColor = color; // Players Color
        }
        public string getPlayerName()
        {
            return PlayerName;
        }
        public string getPlayerColor()
        {
            return PlayerColor;
        }
    }
}
