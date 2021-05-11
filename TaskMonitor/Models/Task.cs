using Newtonsoft.Json;
using System;
using System.Text;

namespace TaskMonitor.Models
{
    public class Task
    {
        [JsonProperty("ID")]
        public int ID { get; set; }
        [JsonProperty("Title")]
        public string Title { get; set; }
        [JsonProperty("Content")]
        public string Content { get; set; }
        [JsonProperty("DateStart")]
        public DateTime DateStart { get; set; }
        [JsonProperty("DateExpire")]
        public DateTime DateExpire { get; set; }
        [JsonProperty("IsDateExpire")]
        public bool IsDateExpire { get; set; }
        [JsonProperty("TaskType")]
        public TaskType TaskType { get; set; }
        [JsonProperty("Remember")]
        public bool Remember { get; set; }

        public Task()
        {

        }
        public Task(string title,string content)
        {
            this.Title = title;
            this.Content = content;
        }
        public override string ToString()
        {
            return string.Format("{0}\t{1}", Title, Content);
        }
    }
}
