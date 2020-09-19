using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meetings
{
    public class MeetingClass
    {
        public class Meeting
        {
            public int StartTime { get; set; }

            public int EndTime { get; set; }

            public Meeting(int startTime, int endTime)
            {
                // Number of 30 min blocks past 9:00 am
                StartTime = startTime;
                EndTime = endTime;
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                if (ReferenceEquals(obj, this))
                {
                    return true;
                }

                var meeting = (Meeting)obj;
                return StartTime == meeting.StartTime && EndTime == meeting.EndTime;
            }

            public override int GetHashCode()
            {
                var result = 17;
                result = result * 31 + StartTime;
                result = result * 31 + EndTime;
                return result;
            }

            public override string ToString()
            {
                return $"({StartTime}, {EndTime})";
            }
        }

        public static List<Meeting> MergeRanges(List<Meeting> meetings)
        {
            // Implement me
	    return new List<Meeting>();
        }
    }
}
