string prodUrl = "<REPLACE_WITH_PROD_URL>";
string token = "<YOUR_TOKEN>";

var client = new RestClient($"{prodUrl}/v1/campaigns");
client.Timeout = -1;

var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", $"Bearer {token}");
request.AddHeader("Content-Type", "application/json");

var requestBody = new {
    label = "My Campaign publipostage",
    sender = "SMS INFO",
    contacts = new[] {
        new { age = "12", numero = "2250000000000", name = "Martial" },
        new { age = "24", numero = "2250000000000", name = "Rita" },
        new { age = "32", numero = "2260000000000", name = "Arolitec" }
    },
    content = "Hello {{name}}, votre numéro est {{numero}}"
};

request.AddJsonBody(requestBody);

IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);
