Dim client As New RestClient("<REPLACE_WITH_PROD_URL>/v1/campaigns/sms")

client.Timeout = -1

Dim request As New RestRequest(Method.POST)

request.AddHeader("Authorization", "Bearer <REPLACE_WITH_YOUR_API_KEY>")
request.AddHeader("Content-Type", "application/json")
Dim body As String = "{" & vbCrLf &
"    ""label"": ""My Campaign publipostage""," & vbCrLf &
"    ""sender"": ""SMS INFO""," & vbCrLf &
"    ""contacts"": [" & vbCrLf &
"        {""age"": ""12"", ""numero"": ""2250000000000"", ""name"": ""Martial""}," & vbCrLf &
"        {""age"": ""24"", ""numero"": ""2250000000000"", ""name"": ""Rita""}," & vbCrLf &
"        {""age"": ""32"", ""numero"": ""2250000000000"", ""name"": ""John""}" & vbCrLf &
"    ]," & vbCrLf &
"    ""content"": ""Hello {{name}}, votre numéro est {{numero}}""" & vbCrLf &
"}"
request.AddParameter("application/json", body, ParameterType.RequestBody)

Dim response As IRestResponse = client.Execute(request)
Console.WriteLine(response.Content)