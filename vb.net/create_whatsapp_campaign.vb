Dim client As New RestClient("<REPLACE_WITH_PROD_URL>/v1/campaigns/whatsapp")

client.Timeout = -1

Dim request As New RestRequest(Method.POST)

request.AddHeader("Authorization", "Bearer <REPLACE_WITH_YOUR_API_KEY>")
request.AddHeader("Content-Type", "application/json")
Dim body As String = "{" & vbCrLf &
"    ""label"": ""My WhatsApp Campaign""," & vbCrLf &
"    ""sender"": ""My Company""," & vbCrLf &
"    ""templateName"": ""order_confirmation""," & vbCrLf &
"    ""contacts"": [""2250000000000"", ""2250000000001"", ""2250000000002""]," & vbCrLf &
"    ""parameters"": [""John"", ""12345""]," & vbCrLf &
"    ""mediaUrl"": ""https://mydomain.com/image.jpg""," & vbCrLf &
"    ""notifyUrl"": ""https://mydomain.com:4444/dlr""," & vbCrLf &
"    ""skipDuplicates"": true," & vbCrLf &
"    ""sendAt"": ""2026-07-20T21:40:00.000Z""" & vbCrLf &
"}"
request.AddParameter("application/json", body, ParameterType.RequestBody)

Dim response As IRestResponse = client.Execute(request)
Console.WriteLine(response.Content)
