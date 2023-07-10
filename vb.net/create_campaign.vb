Dim client As New RestClient("<REPLACE_WITH_PROD_URL>/v1/campaigns")

client.Timeout = -1

Dim request As New RestRequest(Method.POST)

request.AddHeader("Authorization", "Bearer dc408be00542eed70f4e7d1336d9a38735e5fa74")
request.AddHeader("Content-Type", "application/json")
Dim body As String = "{" & vbCrLf &
"    ""label"": ""My Campaign publipostage""," & vbCrLf &
"    ""sender"": ""SMS INFO""," & vbCrLf &
"    ""contacts"": [" & vbCrLf &
"        {""age"": ""12"", ""numero"": ""225074718911"", ""name"": ""Martial""}," & vbCrLf &
"        {""age"": ""24"", ""numero"": ""225070865198"", ""name"": ""Rita""}," & vbCrLf &
"        {""age"": ""32"", ""numero"": ""225076827512"", ""name"": ""Arolitec""}" & vbCrLf &
"    ]," & vbCrLf &
"    ""content"": ""Hello {{name}}, votre numéro est {{numero}}""" & vbCrLf &
"}"
request.AddParameter("application/json", body, ParameterType.RequestBody)

Dim response As IRestResponse = client.Execute(request)
Console.WriteLine(response.Content)