namespace ReverseEverything
{
    public static class Reverse
    {
        public static void ReverseChars(char[] arrayOfChars)
        {
            int leftIndex = 0;
            int rightIndex = arrayOfChars.Length - 1;

            while (leftIndex < rightIndex)
            {
                // Swap characters
                char temp = arrayOfChars[leftIndex];
                arrayOfChars[leftIndex] = arrayOfChars[rightIndex];
                arrayOfChars[rightIndex] = temp;

                // Move towards middle
                leftIndex++;
                rightIndex--;
            }
        }

        public static void ReverseWords(char[] message)
        {
            ReverseCharacters(message, 0, message.Length - 1);

            int currentWordStartIndex = 0;
            for (int i = 0; i <= message.Length; i++)
            {
                if (i == message.Length || message[i] == ' ')
                {
                    ReverseCharacters(message, currentWordStartIndex, i - 1);
                    currentWordStartIndex = i + 1;
                }
            }
        }

        public static void ReverseCharacters(char[] message, int leftIndex, int rightIndex)
        {
            while (leftIndex < rightIndex)
            {
                char temp = message[leftIndex];
                message[leftIndex] = message[rightIndex];
                message[rightIndex] = temp;
                leftIndex++;
                rightIndex--;
            }
        }
    }
}