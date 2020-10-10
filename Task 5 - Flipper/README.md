# TASK - Flipper
1. Download *Flipper.cs*
2. Implement *FindFlippingPoint* method
3. Zip the *Flipper.cs* without Main method if case
4. Ship it!

Once again, I was bored and decided to challenge my students!
I took a dictionary of words and started reading somewhere in the middle. Every word I liked, I wrote down in an array. When I finished the dictionary, I started from the first page and continued until I reached the first written word.

Your job is to find an index from my array where I started from the first page. A flipper point! Like flipping the page, you get it, right?

For example:
```csharp
      var words = new string[]
{       
    "retrograde",
    "undulate",
    "zephyr",
    "aligator",  // <-- this point! => 3 (index)
    "border",
    "banoffee",
    ....
};
```

Tip:
Maybe Binary search is nice algorithm, or not. Who knows.
You can do it in O(lg n)