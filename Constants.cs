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
            /// Sit Spin = SSp
            /// </summary>
            SSp,

            /// <summary>
            /// Upright Spin = USp
            /// </summary>
            USp,

            /// <summary>
            /// Camel Spin = CSp
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
            /// Step Sequence = StSq
            /// </summary>
            StSq,

            /// <summary>
            /// Choreo Sequence = ChSq
            /// </summary>
            ChSq,

            #endregion
        }

        public static int GetCategoryNumber(string categoryName)
        {
            int category = 0;
            
            if(!string.IsNullOrWhiteSpace(categoryName))
            {
                category = categoryName.ToUpper().Contains("Livello1".ToUpper()) ? 1 
                    : categoryName.ToUpper().Contains("Livello2".ToUpper()) ? 2 
                    : 0; 
            }

            return category;
        }

        public static int GetSegmentNumber()
        {
            if (!string.IsNullOrWhiteSpace(Program.Segment))
            {
                if (Program.Segment.Contains("Seg1"))
                {
                    return 1;
                }
                else if (Program.Segment.Contains("Seg2"))
                {
                    return 2;
                }
            }
            
            return 0;
        }
    }
}
