Dim client As New RestClient("<REPLACE_WITH_PROD_URL>/v1/senders/create")

client.Timeout = -1

Dim request As New RestRequest(Method.POST)

request.AddHeader("Authorization", "Bearer dc408be00542eed70f4e7d1336d9a38735e5fa74")
request.AddHeader("Content-Type", "application/json")
Dim body As String = "{" & vbCrLf &
"    ""name"": ""My Sender""," & vbCrLf &
"}"
request.AddParameter("application/json", body, ParameterType.RequestBody)

Dim response As IRestResponse = client.Execute(request)
Console.WriteLine(response.Content)