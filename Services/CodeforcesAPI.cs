using System.Text.Json;
using MyUhuntCard.Models;

namespace MyUhuntCard.Services
{
    public class CodeforcesAPI
    {
        private readonly string Url = new String("https://codeforces.com/api/user.status?handle=");
        private HttpClient Client = new HttpClient();

        static private int CountAccepted(List<CodeforcesSubmission> toSearch)
        {
            int count = 0;
            foreach (CodeforcesSubmission obj in toSearch)
            {
                if (obj.Verdict.ToString() == "OK") count++;
            }

            return count;
        }

        public async Task<Response<int>> GetAcceptedAsync(string Username)
        {
            string result = await Client.GetStringAsync(Url + Username);

            Console.WriteLine(result);

            CodeforcesResponse res = JsonSerializer.Deserialize<CodeforcesResponse>(result);

            if (res.Result == null || res.Result.Count == 0)
            {
                return new Response<int>() { Value = 0 };
            }

            return new Response<int> { Value = CountAccepted(res.Result) };
        }
    }
}
