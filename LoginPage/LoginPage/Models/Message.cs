using Newtonsoft.Json.Linq;

namespace LoginPage.Models
{
    public class Output_Data
    {
        public int status { get; set; }
        public string message { get; set; }
        public JToken data { get; set; }
    }
}
