# TASK 2 - Meetings
1. Download *Meeting.cs*
2. Implement *MergeRanges* method
3. Zip the *Meeting.cs*
4. Ship it!

You have a simple calendar where you want to add a feature that shows when everyone has time.
What you know is when teams are having a meeting. A meeting is an object with *StartTime* and *EndTime*. These represent the number of 30 minutes blocks past 9:00.

For example:
```csharp
    var meeting =  new Meeting(4, 5); // meeting from 11:00 - 11:30
```

Your method *MergeRanges()* takes multiple meetings and returns a list of condensed ranges.

For example:
```csharp
    [Meeting(0, 1), Meeting(3, 5), Meeting(4, 8), Meeting(10, 12), Meeting(9, 10)]
```


result is:
```csharp
    [Meeting(0, 1), Meeting(3, 8), Meeting(9, 12)]
```

##### Tip:
Do not assume the meetings are in order.