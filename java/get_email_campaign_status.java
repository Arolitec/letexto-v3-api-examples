import okhttp3.*;

import java.io.IOException;

public class Main {
    public static void main(String[] args) throws IOException {
        OkHttpClient client = new OkHttpClient().newBuilder().build();

        MediaType mediaType = MediaType.parse("text/plain");
        RequestBody body = RequestBody.create(mediaType, "");

        Request request = new Request.Builder()
                .url("<REPLACE_WITH_PROD_URL>/v1/campaigns/emails/<YOUR_CAMPAIGN_ID>/status?token=<REPLACE_WITH_YOUR_API_KEY>")
                .method("GET", body)
                .build();

        Response response = client.newCall(request).execute();
        String responseBody = response.body().string();
        System.out.println(responseBody);
    }
}
