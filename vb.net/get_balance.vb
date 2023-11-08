Dim client As New RestClient("<REPLACE_WITH_PROD_URL>/v1/users/balance")
client.Timeout = -1

Dim request As New RestRequest(Method.GET)
request.AddHeader("Authorization", "Bearer dc408be00542eed70f4e7d1336d9a38735e5fa74")

Dim body As String = ""
request.AddParameter("text/plain", body, ParameterType.RequestBody)

Dim response As IRestResponse = client.Execute(request)

Console.WriteLine(response.Content)
