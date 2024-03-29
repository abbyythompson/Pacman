namespace PacmanLibrary.Constants
{
    public static class Constants
    {
        public const string EmptyCell = "   ";
        public const string FoodCell = " . ";
        public const string Wall = " + ";
        public const string PacmanUp = " v ";
        public const string PacmanDown = " ^ ";
        public const string PacmanLeft = " > ";
        public const string PacmanRight = " < ";
        public const string Ghost = " o ";

        public const string NewLine = "\n";
        
        public const string Score = "Score:";
        public const string Level = "Level:";
        public const string Lives = "Lives:";

        public const string ExceptionForRowsAndCols = "Array size must be greater or equal to 1";
        public const string ExceptionForPlacingPacmanOffTheBoard = "You've placed pacman off the board";
        public const string ExceptionForPlacingGhostOffTheBoard = "You've placed ghost off the board";

        
    }
}