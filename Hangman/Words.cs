namespace Hangman
{
    public enum HangmanWords
    {
        Sloth,
        Jaguar,
        Gorilla,
        Tiger,
        Macaw,
        Lemur,
        Orangutans,
        Toucan,
        Caiman,
        Ocelot
    }

    public static class HangmanHints
    {
        public static string GetHint(HangmanWords word)
        {
            switch (word)
            {
                case HangmanWords.Sloth:
                    return "Slow as molasses...";
                    break;
                case HangmanWords.Jaguar:
                    return "Another name for a car.";
                    break;
                case HangmanWords.Gorilla:
                    return "Climbs buildings and captures women!";
                    break;
                case HangmanWords.Tiger:
                    return "Has a cereal brand.";
                    break;
                case HangmanWords.Macaw:
                    return "Wanna a cracker?";
                    break;
                case HangmanWords.Lemur:
                    return "King Julian!!";
                    break;
                case HangmanWords.Orangutans:
                    return "They have gross butts.";
                    break;
                case HangmanWords.Toucan:
                    return "Colorful and has a cereal brand.";
                    break;
                case HangmanWords.Caiman:
                    return "Jack";
                    break;
                case HangmanWords.Ocelot:
                    return "A pet in minecraft...";
                    break;
                default:
                    return "No hint available.";
                    break;
            }
        }
    }
}