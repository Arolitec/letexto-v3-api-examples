import okhttp3.*;

import java.io.IOException;

public class Main {
    public static void main(String[] args) throws IOException {
        OkHttpClient client = new OkHttpClient().newBuilder().build();

        Request request = new Request.Builder()
                .url("<REPLACE_WITH_PROD_URL>/v1/users/balance?token=<REPLACE_WITH_YOUR_MESSAGE_ID>")
                .method("GET", null)
                .build();

        Response response = client.newCall(request).execute();
        String responseBody = response.body().string();
        System.out.println(responseBody);
    }
}
