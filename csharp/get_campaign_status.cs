//replace with your own values

var client = new RestClient("http://localhost:3333/v1/campaigns/1/status");
client.Timeout = -1;
var request = new RestRequest(Method.GET);
request.AddHeader("Authorization", "Bearer dc408be00542eed70f4e7d1336d9a38735e5fa74");
var body = @"";
request.AddParameter("text/plain", body, ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);