namespace ClubCompFS
{
    public static class Constants
    {
        public const int TOTAL_COMPONENTS_COUNT = 3; // "Skating Skills", "Composition", "Presentation"

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
    }
}
