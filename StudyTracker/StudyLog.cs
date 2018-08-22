using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace StudyTracker
{
    public class StudyLog
    {
        private string topic;
        private DateTime startTime;
        private DateTime endTime;
        private DateTime startDate;
        private DateTime endDate;
        private TimeSpan timeStudied;

        [JsonProperty("Description")]
        public string Description { get; set; }

        public StudyLog()
        {
            //empty studyLog

        }
        public StudyLog(string topic, DateTime startTime, DateTime startDate, string description)
        {
            Topic = topic;
            StartTime = startTime;
            StartDate = startDate;
            Description = description;
        }
        [JsonProperty("Topic")]
        public string Topic
        {
            get
            {
                return topic;
            }
            set
            {
                char[] delims = { '\r', '\n' };
                value = value.Trim(delims);

                if (value.Trim(' ') != string.Empty)
                {
                    topic = value;
                }
            }
        }

        [JsonProperty("StartTime")]
        public DateTime StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                if (value > DateTime.MinValue)
                {
                    startTime = value;
                }
            }
        }

        [JsonProperty("EndTime")]
        public DateTime EndTime
        {
            get
            {
                return endTime;
            }
            set
            {
                if (value > DateTime.MinValue)
                {
                    endTime = value;
                }
            }
        }

        [JsonProperty("StartDate")]
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                if (value > DateTime.MinValue)
                {
                    startDate = value;
                }
            }
        }

        [JsonProperty("EndDate")]
        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                if (value > DateTime.MinValue)
                {
                    endDate = value;
                }
            }
        }

        [JsonProperty("TimeStudied")]
        public TimeSpan TimeStudied
        {
            get
            {
                return timeStudied;
            }
            set
            {
                if (value > TimeSpan.MinValue)
                {
                    timeStudied = value;
                }
            }
        }


    }
}
