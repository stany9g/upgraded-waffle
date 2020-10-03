# Task - Multiplication
1. Download *MultiplicationHelper.cs*
2. Implement *GetHighestProductOfThree* method
3. Zip the *MultiplicationHelper.cs* without Main method if case
4. Ship it!

I give you minimum three integers (max 100000) and you give me the highest product of three integers.

For example:
```csharp
    int[] numbers = { 10, 5, 9, 4 };

    // 10 * 9 * 5 = 450
    GetHighestProductOfThree(numbers);
```

Should work for negative numbers as well.
```csharp
    int[] numbers = { -10, -10, 2, 5};

    // -10 * -10 * 5 = 500
    GetHighestProductOfThree(numbers);
```

### Tip:
You can do it in O(n) time! 