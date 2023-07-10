//replace with your own values

Dim client As New RestClient("<REPLACE_WITH_PROD_URL>/v1/messages/send?from=" + Uri.EscapeDataString("SMS INFO") + "&to=2250585743342&content=Hello API!&username=TR_c20c7c07429&password=1ad05b50&dlrUrl=" + Uri.EscapeDataString("https://mydomain.com:4444/dlr") + "&dlrMethod=GET&customData=customData&sendAt=2023-02-13T21:40:00.000Z")
client.Timeout = -1
Dim request As New RestRequest(Method.GET)
Dim response As IRestResponse = client.Execute(request)
Console.WriteLine(response.Content)