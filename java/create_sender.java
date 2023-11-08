import okhttp3.*;

import java.io.IOException;

public class Main {
    public static void main(String[] args) throws IOException {
        OkHttpClient client = new OkHttpClient().newBuilder().build();

        MediaType mediaType = MediaType.parse("application/json");
        RequestBody body = RequestBody.create(mediaType, "{\n    \"name\": \"My Sender\"\n}");

        Request request = new Request.Builder()
                .url("<REPLACE_WITH_PROD_URL>/v1/senders/create")
                .method("POST", body)
                .addHeader("Authorization", "Bearer <YOUR_TOKEN>")
                .addHeader("Content-Type", "application/json")
                .build();

        Response response = client.newCall(request).execute();
        String responseBody = response.body().string();
        System.out.println(responseBody);
    }
}
