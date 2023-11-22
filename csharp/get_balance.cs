string prodUrl = "<REPLACE_WITH_PROD_URL>";
string token = "<YOUR_TOKEN>";

var client = new RestClient($"{prodUrl}/v1/users/balance?token=<REPLACE_WITH_YOUR_MESSAGE_ID>");
client.Timeout = -1;

var request = new RestRequest(Method.GET);

IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);
