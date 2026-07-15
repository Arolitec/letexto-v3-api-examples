using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string apiUrl = "<REPLACE_WITH_PROD_URL>/v1/whatsapp/send";
        string token = "<REPLACE_WITH_YOUR_API_KEY>";

        var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

        var requestData = new
        {
            from = "My Company",
            to = "2250000000000",
            templateName = "order_confirmation",
            parameters = new[] { "John", "12345" },
            mediaUrl = "https://mydomain.com/image.jpg",
            notifyUrl = "https://mydomain.com:4444/dlr"
        };

        var json = JsonSerializer.Serialize(requestData);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await httpClient.PostAsync(apiUrl, content);
        var responseBody = await response.Content.ReadAsStringAsync();

        Console.WriteLine(responseBody);
    }
}
