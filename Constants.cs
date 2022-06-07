using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClubCompFS
{
    public static class Constants
    {
        public static bool IsValidCharForClubName(char keyChar)
        {
            bool isValidCharForClubName = true;
            switch (keyChar)
            {
                case '"':
                case '&':
                //case '\'': // enable apostrophe for club name
                case ':':
                case ';':
                case '<':
                case '>':
                    //e.Handled = true;
                    isValidCharForClubName = false;
                    break;
            }
            return isValidCharForClubName;
        }
    }
}
