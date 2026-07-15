string prodUrl = "<REPLACE_WITH_PROD_URL>";
string token = "<REPLACE_WITH_YOUR_API_KEY>";

var client = new RestClient($"{prodUrl}/v1/campaigns/whatsapp");
client.Timeout = -1;

var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", $"Bearer {token}");
request.AddHeader("Content-Type", "application/json");

var requestBody = new {
    label = "My WhatsApp Campaign",
    sender = "My Company",
    templateName = "order_confirmation",
    contacts = new[] { "2250000000000", "2250000000001", "2250000000002" },
    parameters = new[] { "John", "12345" },
    mediaUrl = "https://mydomain.com/image.jpg",
    notifyUrl = "https://mydomain.com:4444/dlr",
    skipDuplicates = true,
    sendAt = "2026-07-20T21:40:00.000Z"
};

request.AddJsonBody(requestBody);

IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);
