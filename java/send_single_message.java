import okhttp3.*;

import java.io.IOException;

public class Main {
    public static void main(String[] args) throws IOException {
        OkHttpClient client = new OkHttpClient().newBuilder().build();
        
        String prodUrl = "<REPLACE_WITH_PROD_URL>";
        String token = "<REPLACE_WITH_YOUR_API_KEY>";
        
        MediaType mediaType = MediaType.parse("application/json");
        String jsonBody = "{" +
                "\"from\": \"SMS INFO\"," +
                "\"to\": \"2250000000000\"," +
                "\"content\": \"Hello API!\"," +
                "\"dlrUrl\": \"https://mydomain.com:4444/dlr\"," +
                "\"dlrMethod\": \"GET\"," +
                "\"customData\": \"customData\"," +
                "\"sendAt\": \"2023-02-13T21:40:00.000Z\"" +
                "}";
        
        RequestBody body = RequestBody.create(jsonBody, mediaType);
        
        Request request = new Request.Builder()
                .url(prodUrl + "/v1/messages/send")
                .method("POST", body)
                .addHeader("Authorization", "Bearer " + token)
                .addHeader("Content-Type", "application/json")
                .build();
        
        try (Response response = client.newCall(request).execute()) {
            String responseBody = response.body().string();
            System.out.println(responseBody);
        }
    }
}