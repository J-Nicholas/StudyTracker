using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyTracker
{
    class TopicTime
    {
        public string TopicName { get; set; }
        public TimeSpan TimeSpent { get; set; }

        public TopicTime()
        {

        }
        public TopicTime(string topic, TimeSpan timeSpent)
        {
            TopicName = topic;
            TimeSpent = timeSpent;
        }
    }
}
