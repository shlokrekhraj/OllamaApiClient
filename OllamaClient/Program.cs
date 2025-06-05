using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OllamaClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var requestData = new
            {
                model = "llama3",
                prompt = "Generate a fake sales report for Q2.",
                max_tokens = 100
            };

            string json = JsonSerializer.Serialize(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("http://localhost:11434/v1/completions", content);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine("✅ Response from Ollama:");
                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("❌ Error calling Ollama API:");
                Console.WriteLine(e.Message);
            }
        }
    }
}

