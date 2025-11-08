using System.Net.Http;

namespace LoremPicsumApi
{
    public class LoremPicsum
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://picsum.photos";
        public LoremPicsum()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetImages()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/v2/list/");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetImage(int id)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/id/{id}/info/");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
