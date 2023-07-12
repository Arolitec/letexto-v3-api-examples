string apiUrl = "<REPLACE_WITH_PROD_URL>/v1/messages/send";
string from = "SMS INFO";
string to = "22500000000000";
string content = "Hello API!";
string token = "<YOUR_TOKEN>";
string dlrUrl = "https://mydomain.com:4444/dlr";
string dlrMethod = "GET";
string customData = "customData";
string sendAt = "2023-02-13T21:40:00.000Z";

var client = new RestClient(apiUrl);
client.Timeout = -1;

var request = new RestRequest(Method.GET);
request.AddParameter("from", from);
request.AddParameter("to", to);
request.AddParameter("content", content);
request.AddParameter("token", token);
request.AddParameter("dlrUrl", dlrUrl);
request.AddParameter("dlrMethod", dlrMethod);
request.AddParameter("customData", customData);
request.AddParameter("sendAt", sendAt);

IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);
