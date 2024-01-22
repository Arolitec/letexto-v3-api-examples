Dim client As New RestClient("<REPLACE_WITH_PROD_URL>/v1/campaigns/sms/<YOUR_CAMPAIGN_ID>/status?token=<REPLACE_WITH_YOUR_API_KEY>")
client.Timeout = -1

Dim request As New RestRequest(Method.GET)

Dim body As String = ""
request.AddParameter("text/plain", body, ParameterType.RequestBody)

Dim response As IRestResponse = client.Execute(request)

Console.WriteLine(response.Content)
