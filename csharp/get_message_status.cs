string prodUrl = "<REPLACE_WITH_PROD_URL>";
string token = "<REPLACE_WITH_YOUR_API_KEY>";
string messageId = "your message id";

var client = new RestClient($"{prodUrl}/v1/messages/{messageId}/status?token={token}");
client.Timeout = -1;

var request = new RestRequest(Method.GET);

IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);
