string prodUrl = "<REPLACE_WITH_PROD_URL>";
string token = "<YOUR_TOKEN>";

var client = new RestClient($"{prodUrl}/v1/campaigns");
client.Timeout = -1;

var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", $"Bearer {token}");
request.AddHeader("Content-Type", "application/json");

var requestBody = new {
  name = "My Sender",
};

request.AddJsonBody(requestBody);

IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);