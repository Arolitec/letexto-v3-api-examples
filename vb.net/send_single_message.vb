Dim url As String = "<REPLACE_WITH_URL_PROD>/v1/messages/send?from=" + Uri.EscapeDataString("SMS INFO") + "&to=2250585743342&content=Hello API!&token=<YOUR_TOKEN>&dlrUrl=" + Uri.EscapeDataString("https://mydomain.com:4444/dlr") + "&dlrMethod=GET&customData=customData&sendAt=2023-02-13T21:40:00.000Z"
Dim client As New RestClient(url)
client.Timeout = -1

Dim request As New RestRequest(Method.GET)
Dim response As IRestResponse = client.Execute(request)

Console.WriteLine(response.Content)
