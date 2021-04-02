using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Classes
{
    class PlayerNameValidation
    {

        //Check if string is blank
        public bool IsBlank(string str)
        {
            return (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str));
        }

        //Check if name contains a digit
        public bool IsDigit(string str)
        {
            return (str.Any(char.IsDigit));
        }

        //Check if names match
        public bool IsSameName(string player1, string player2)
        {
            return (player1 == player2);
        }
    }
}
