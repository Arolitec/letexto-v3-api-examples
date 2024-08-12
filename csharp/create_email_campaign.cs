string prodUrl = "<REPLACE_WITH_PROD_URL>";
string token = "<REPLACE_WITH_YOUR_API_KEY>";

var client = new RestClient($"{prodUrl}/v1/campaigns/emails");
client.Timeout = -1;

var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", $"Bearer {token}");
request.AddHeader("Content-Type", "application/json");

var requestBody = new {
    label: "My Campaign publipostage",
    from: "sender@mail.com",
    recipients: ["test@mail.com", "test@mail.com", "test@mail.com"],
    content: "Hello {{name}}, votre numéro est {{numero}}",
    subject: "subject",
};

request.AddJsonBody(requestBody);

IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);
