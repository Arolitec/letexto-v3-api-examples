//replace with your own values

var client = new RestClient("http://localhost:3333/v1/campaigns");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", "Bearer dc408be00542eed70f4e7d1336d9a38735e5fa74");
request.AddHeader("Content-Type", "application/json");
var body = @"{" + "\n" +
@"    ""label"": ""My Campaign publipostage""," + "\n" +
@"    ""sender"": ""SMS INFO""," + "\n" +
@"    ""contacts"": [" + "\n" +
@"        {""age"": ""12"", ""numero"": ""225074718911"", ""name"": ""Martial""}," + "\n" +
@"        {""age"": ""24"", ""numero"": ""225070865198"", ""name"": ""Rita""}," + "\n" +
@"        {""age"": ""32"", ""numero"": ""225076827512"", ""name"": ""Arolitec""}" + "\n" +
@"    ]," + "\n" +
@"    ""content"": ""Hello {{name}}, votre numéro est {{numero}}""" + "\n" +
@"}";
request.AddParameter("application/json", body, ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);