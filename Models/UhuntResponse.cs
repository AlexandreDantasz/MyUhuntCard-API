using System.Text.Json.Serialization;

namespace MyUhuntCard.Models
{
    public class UhuntResponse
    {
        [JsonPropertyName("subs")]
        public int[][] Subs { get; set; }
    }
}
