string prodUrl = "<REPLACE_WITH_PROD_URL>";
string token = "<YOUR_TOKEN>";
string messageId = "your message id";

var client = new RestClient($"{prodUrl}/v1/messages/{messageId}/status");
client.Timeout = -1;

var request = new RestRequest(Method.GET);
request.AddHeader("Authorization", $"Bearer {token}");

IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);
