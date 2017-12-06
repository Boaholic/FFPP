using System;


namespace FloatyFloatPewPew
{
    public static class GlobalState
    {
        // Reference to the main menu form instance.
        public static MainMenuForm MainMenuForm { get; set; }

        // Method for generating random numbers.
        public static int RandomNumber(int max)
        {
            Random random = new Random();
            return random.Next(max);
        }
    }
}
