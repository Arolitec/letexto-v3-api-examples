string prodUrl = "<REPLACE_WITH_PROD_URL>";
string token = "<REPLACE_WITH_YOUR_API_KEY>";

var client = new RestClient($"{prodUrl}/v1/senders");
client.Timeout = -1;

var request = new RestRequest(Method.GET);
request.AddHeader("Authorization", $"Bearer {token}");
request.AddHeader("Content-Type", "application/json");

request.AddQueryParameter("query", "searchTerm");        
request.AddQueryParameter("status", "PENDING");         
request.AddQueryParameter("allAccounts", "true");      

IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);