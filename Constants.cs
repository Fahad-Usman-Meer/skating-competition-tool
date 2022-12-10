namespace ClubCompFS
{
    public static class Constants
    {
        public const int TOTAL_COMPONENTS_COUNT = 2; // "Skating Skills", "Presentation"

        public static bool IsValidCharForClubName(char keyChar)
        {
            bool isValidCharForClubName = true;
            switch (keyChar)
            {
                case '"':
                case '&':
                //case '\'': //TODO: enable apostrophe for club name
                case ':':
                case ';':
                case '<':
                case '>':
                    isValidCharForClubName = false;  //e.Handled = true;
                    break;
            }
            return isValidCharForClubName;
        }

        public static bool IsValidProgramComponentValueV2(double enteredValue)
        {
            if (enteredValue < 0.25 || enteredValue > 3)
            {
                return false;
            }
            return true;
        }
    }
}
