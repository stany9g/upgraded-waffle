using System.Collections.Generic;

namespace WordCloud
{
    public class WordCloudEngine
    {
        public IDictionary<string, int> Words { get; private set; }

        public WordCloudEngine(string sentence)
        {
            Words = new Dictionary<string, int>();
            CreateCloud(sentence);
        }

        private void CreateCloud(string sentence)
        {
            // Count the frequency of each word
        }
    }
}