Dim client As New RestClient("<REPLACE_WITH_PROD_URL>/v1/senders")

client.Timeout = -1

Dim request As New RestRequest(Method.GET)

request.AddHeader("Authorization", "Bearer <REPLACE_WITH_YOUR_API_KEY>")
request.AddHeader("Content-Type", "application/json")

request.AddQueryParameter("query", "searchTerm")        
request.AddQueryParameter("status", "PENDING")         
request.AddQueryParameter("allAccounts", "true")      

Dim response As IRestResponse = client.Execute(request)
Console.WriteLine(response.Content)