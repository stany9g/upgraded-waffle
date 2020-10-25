# Task - WordCloud
1. Download *WordCloudEngine.cs*
2. Implement *CreateCloud* method
3. Zip the *WordCloudEngine.cs* without Main method if case
4. Ship it!

This is going to be interesting. I was doing some seminar work and was using google sheets where I found a word cloud addon, which I liked. For those who don't know what it is. 
![wordcloud](wordcloud.jpg)

Are you getting excited yet? 

Task for you will be just a backend stuff I want you to implement a word count. Where when I create an instance of WordCloudEngine I want to pass it a words and then fill the dictionary with appropriate words because there are a lot of ways how you make decision of some edge cases. There are lots of valid solutions but because I need to test it I will give you constraints or decision I made for you.

1. Only make a word uppercase if it is always uppercase in the original sentence.
2. If we have a sentence with the same word twice, one with uppercase and second lowercase only have one version in our dictionary. For example - "Cliff" "cliff". Always have the last version occured in the dictionary. I.e. "Cliff is the cliff" would mean that you store 
```csharp
     ["cliff", 2]
```
3. Split words by punctuation, dashes, spaces, and ellipses—making (...) sure to include hyphens surrounded by characters.

You should be able do it in O(n).

Some input data:
- I like trains
- Apple short pie? Yummy!
- Lol - gg-wp easy
- Mmm...mmm...reasons...reasons
- John's Shop: Peter's Bread
