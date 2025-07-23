Imports System.Net.Http
Imports System.Text
Imports System.Text.Json

Module Module1
    Async Function SendSms() As Task
        Dim apiUrl As String = "<REPLACE_WITH_PROD_URL>/v1/messages/send"
        Dim token As String = "<REPLACE_WITH_YOUR_API_KEY>"

        Using httpClient As New HttpClient()
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}")

            Dim requestData = New With {
                .from = "SMS INFO",
                .to = "2250000000000",
                .content = "Hello API!",
                .dlrUrl = "https://mydomain.com:4444/dlr",
                .dlrMethod = "GET",
                .customData = "customData",
                .sendAt = "2023-02-13T21:40:00.000Z"
            }

            Dim json As String = JsonSerializer.Serialize(requestData)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await httpClient.PostAsync(apiUrl, content)
            Dim responseBody As String = Await response.Content.ReadAsStringAsync()

            Console.WriteLine(responseBody)
        End Using
    End Function

    Sub Main()
        SendSms().Wait()
    End Sub
End Module