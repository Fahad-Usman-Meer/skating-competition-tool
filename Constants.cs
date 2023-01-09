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

        public static bool IsValidCharForJudgeInput(char keyChar)
        {
            bool isValidCharForJudgeName = false;
            switch (keyChar)
            {
                case '\b':
                case '-':
                case '+':
                case '0':
                case '1':
                //case '2':
                //case '3':
                //case '4':
                //case '5':
                    isValidCharForJudgeName = true;
                    break;
            }
            return isValidCharForJudgeName;
        }

        public static bool IsValidProgramComponentValueV2(double enteredValue)
        {
            if (enteredValue < 0.25 || enteredValue > 3)
            {
                return false;
            }
            return true;
        }

        public enum SpinsAndSequences
        {
            #region Spins
            /// <summary>
            /// SitSpin = SSp
            /// </summary>
            SSp,

            /// <summary>
            /// UprightSpin = USp
            /// </summary>
            USp,

            /// <summary>
            /// Camel Spin
            /// </summary>
            CSp,

            /// <summary>
            /// Combo Spin-2  = CoSp2
            /// or
            /// Combo Spin-3  = CoSp3
            /// </summary>
            CoSp,

            #endregion

            #region Sequences

            /// <summary>
            /// Step Sequence
            /// </summary>
            StSq,

            /// <summary>
            /// Choreo Sequence
            /// </summary>
            ChSq,

            #endregion
        }
    }
}
