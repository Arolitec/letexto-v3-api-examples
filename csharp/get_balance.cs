string prodUrl = "<REPLACE_WITH_PROD_URL>";

var client = new RestClient($"{prodUrl}/v1/users/balance?token=<REPLACE_WITH_YOUR_API_KEY>");
client.Timeout = -1;

var request = new RestRequest(Method.GET);

IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);
