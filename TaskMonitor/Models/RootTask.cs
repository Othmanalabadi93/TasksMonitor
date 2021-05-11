using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TaskMonitor.Models
{
    public class RootTask
    {
        [JsonProperty("Tasks")]
        public List<Task> Tasks { get; set; }
    }
}
