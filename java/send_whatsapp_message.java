import okhttp3.*;

import java.io.IOException;

public class Main {
    public static void main(String[] args) throws IOException {
        OkHttpClient client = new OkHttpClient().newBuilder().build();

        String prodUrl = "<REPLACE_WITH_PROD_URL>";
        String token = "<REPLACE_WITH_YOUR_API_KEY>";

        MediaType mediaType = MediaType.parse("application/json");
        String jsonBody = "{" +
                "\"from\": \"My Company\"," +
                "\"to\": \"2250000000000\"," +
                "\"templateName\": \"order_confirmation\"," +
                "\"parameters\": [\"John\", \"12345\"]," +
                "\"mediaUrl\": \"https://mydomain.com/image.jpg\"," +
                "\"notifyUrl\": \"https://mydomain.com:4444/dlr\"" +
                "}";

        RequestBody body = RequestBody.create(jsonBody, mediaType);

        Request request = new Request.Builder()
                .url(prodUrl + "/v1/whatsapp/send")
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
