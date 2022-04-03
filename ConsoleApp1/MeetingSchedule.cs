using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MeetingSchedule: Meeting
    {
        public List<Meeting> Meetings = new List<Meeting>();
        public void SetMeeting(string fullName, DateTime from, DateTime To)
        {
           
            if(FromDate == from&& ToDate== To)
            {
                throw new Exception("bele bir Meetin var");
            }
             Meeting meeting = new Meeting();
            DateTime[] dateTimes = new DateTime[0];
            {
                Array.Resize(ref dateTimes,dateTimes.Length+1);
                dateTimes[dateTimes.Length-1] = from;
            }
        }
        public int FindMeetingsCount(DateTime time)
        {
            int count = 0;
            for (int i = 0; i < DateTime.Now.Hour; i++)
            {
                if(time.Hour == i)
                {
                    count++;    
                }
            }
            return count;
        }
        public bool IsExistsMeetingByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Name duzgun daxil etmediniz");
            else foreach (Meeting meeting in Meetings)
                {
                    if (meeting.Name.Contains(name))
                    {
                        return true;
                    }
                } 
            return false;   
        }
        public List<Meeting> GetExistMeetings(string name)
        {
            List<Meeting> newlist = new List<Meeting>();
            foreach (Meeting meeting in Meetings)
            {
                if (meeting.Name.Contains(name))
                    newlist.Add(meeting);
            }
            return newlist;
        }

    }
}
