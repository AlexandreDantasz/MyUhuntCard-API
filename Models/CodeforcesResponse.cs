using System.Text.Json.Serialization;

namespace MyUhuntCard.Models
{
    public class CodeforcesResponse
    {
        [JsonPropertyName("result")]
        public List<CodeforcesSubmission> Result { get; set; } = [];
    }
}
