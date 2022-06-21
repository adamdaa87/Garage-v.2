using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_v._2.UI
{
    public class EventLog
    {
        private Queue<string> log;
        private int maxSize;

        public EventLog(int maxSize)
        {
            log = new Queue<string>();
            this.maxSize = maxSize;
        }

        public void Clear()
        {
            log.Clear();
        }

        public void Add(string message)
        {
            if(log.Count == maxSize)
            {
                log.Dequeue();
            }
            log.Enqueue($"{DateTime.Now.ToString("HH:mm:ss")} {message}");
        }

        public string[] GetLogEntries()
        {
            List<string> entries = new List<string>();
            foreach(string entry in log)
            {
                entries.Add(entry);
            }
            return entries.ToArray();
        }
    }
}
