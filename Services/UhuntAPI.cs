using System.Text.Json;
using MyUhuntCard.Models;

namespace MyUhuntCard.Services
{
    public class UhuntAPI
    {
        private string Url = new String("https://uhunt.onlinejudge.org/api");
        private HttpClient Client = new HttpClient();
        private string ErrorMessage = new String("Erro na conexão com a API do UVA");
        public async Task<Response<string>> GetUserIDAsync(string Username)
        {
            try
            {
                string res = await Client.GetStringAsync($"{Url}/uname2uid/{Username}");
                if (!String.IsNullOrEmpty(res))
                {
                    return new Response<string> { Value = res };
                }
                return new Response<string> { Message = "ID não encontrado" };
            }
            catch 
            {
                return new Response<string> { Message = ErrorMessage };
            }
        }

        public async Task<Response<int>> GetAcceptedAsync(string UserID)
        {
            try
            {
                string res = await Client.GetStringAsync($"{Url}/subs-user/{UserID}");
                if (!String.IsNullOrEmpty(res))
                {
                    UhuntResponse result = JsonSerializer.Deserialize<UhuntResponse>(res)!;
                    if (result.Subs.Length == 0) return new Response<int> { Message = "ID inválido" };

                    int counterAccepteds = 0;

                    foreach (int[] number in result.Subs)
                    {
                        if (number[2] == 90) counterAccepteds++;
                    }

                    return new Response<int> { Value = counterAccepteds };
                }

                return new Response<int> { Message = "String vazia" };
            }
            catch
            {
                return new Response<int> { Message = ErrorMessage };
            }
        }
    }
}
