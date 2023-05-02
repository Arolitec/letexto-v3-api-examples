//replace with your own values

var client = new RestClient("http://localhost:3333/v1/messages/send?from=SMS INFO&to=2250585743342&content=Hello API!&username=TR_c20c7c07429&password=1ad05b50&dlrUrl=https://mydomain.com:4444/dlr&dlrMethod=GET&customData=customData&sendAt=2023-02-13T21:40:00.000Z");
client.Timeout = -1;
var request = new RestRequest(Method.GET);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);