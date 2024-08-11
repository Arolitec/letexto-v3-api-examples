Dim client As New RestClient("<REPLACE_WITH_PROD_URL>/v1/campaigns/emails")

client.Timeout = -1

Dim request As New RestRequest(Method.POST)

request.AddHeader("Authorization", "Bearer <REPLACE_WITH_YOUR_API_KEY>")
request.AddHeader("Content-Type", "application/json")
Dim body As String = "{" & vbCrLf &
"    ""label"": ""My Campaign publipostage""," & vbCrLf &
"    ""from": "sender@mail.com""," & vbCrLf &
"    ""recipients"": [" & vbCrLf &
"        ""test@mail.com""," & vbCrLf &
"        ""test@mail.com""," & vbCrLf &
"        ""test@mail.com""," & vbCrLf &
"    ],"  & vbCrLf &
"     ""subject"": ""subject""," & vbCrLf &
"    ""content"": ""Hello {{name}}, votre numéro est {{numero}}""" & vbCrLf &
"}"
request.AddParameter("application/json", body, ParameterType.RequestBody)

Dim response As IRestResponse = client.Execute(request)
Console.WriteLine(response.Content)