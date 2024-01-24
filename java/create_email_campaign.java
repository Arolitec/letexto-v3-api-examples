import okhttp3.*;

import java.io.IOException;

public class Main {
    public static void main(String[] args) throws IOException {
        OkHttpClient client = new OkHttpClient().newBuilder().build();

        MediaType mediaType = MediaType.parse("application/json");
        RequestBody body = RequestBody.create(mediaType, "{\n    \"label\": \"My Campaign publipostage\",\n    \"sender\": \"SMS INFO\",\n    \"contacts\": [\n        {\"age\": \"12\", \"numero\": \"2250000000000\", \"name\": \"Martial\"},\n        {\"age\": \"24\", \"numero\": \"2250000000000\", \"name\": \"Rita\"},\n        {\"age\": \"32\", \"numero\": \"2250000000000\", \"name\": \"John\"}\n    ],\n    \"content\": \"Hello {{name}}, votre numéro est {{numero}}\"\n}");

        Request request = new Request.Builder()
                .url("<REPLACE_WITH_PROD_URL>/v1/campaigns/emails")
                .method("POST", body)
                .addHeader("Authorization", "Bearer <REPLACE_WITH_YOUR_API_KEY>")
                .addHeader("Content-Type", "application/json")
                .build();

        Response response = client.newCall(request).execute();
        String responseBody = response.body().string();
        System.out.println(responseBody);
    }
}
