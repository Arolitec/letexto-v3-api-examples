using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string apiUrl = "<REPLACE_WITH_PROD_URL>/v1/messages/send";
        string token = "<REPLACE_WITH_YOUR_API_KEY>";

        var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

        var requestData = new
        {
            from = "SMS INFO",
            to = "2250000000000",
            content = "Hello API!",
            dlrUrl = "https://mydomain.com:4444/dlr",
            dlrMethod = "GET",
            customData = "customData",
            sendAt = "2023-02-13T21:40:00.000Z"
        };

        var json = JsonSerializer.Serialize(requestData);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await httpClient.PostAsync(apiUrl, content);
        var responseBody = await response.Content.ReadAsStringAsync();

        Console.WriteLine(responseBody);
    }
}