Imports System.Net.Http
Imports System.Text
Imports System.Text.Json

Module Module1
    Async Function SendWhatsAppMessage() As Task
        Dim apiUrl As String = "<REPLACE_WITH_PROD_URL>/v1/whatsapp/send"
        Dim token As String = "<REPLACE_WITH_YOUR_API_KEY>"

        Using httpClient As New HttpClient()
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}")

            Dim requestData = New With {
                .from = "My Company",
                .to = "2250000000000",
                .templateName = "order_confirmation",
                .parameters = New String() {"John", "12345"},
                .mediaUrl = "https://mydomain.com/image.jpg",
                .notifyUrl = "https://mydomain.com:4444/dlr"
            }

            Dim json As String = JsonSerializer.Serialize(requestData)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await httpClient.PostAsync(apiUrl, content)
            Dim responseBody As String = Await response.Content.ReadAsStringAsync()

            Console.WriteLine(responseBody)
        End Using
    End Function

    Sub Main()
        SendWhatsAppMessage().Wait()
    End Sub
End Module
