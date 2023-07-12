import okhttp3.OkHttpClient;
import okhttp3.Request;
import okhttp3.Response;

import java.io.IOException;
import java.net.URLEncoder;

public class Main {
    public static void main(String[] args) throws IOException {
        OkHttpClient client = new OkHttpClient().newBuilder().build();
        
        String encodedURL = "<REPLACE_WITH_PROD_URL>/v1/messages/send?from=" +
                URLEncoder.encode("SMS INFO", "UTF-8") +
                "&to=2250000000000&content=Hello API!&token=<YOUR_TOKEN>&dlrUrl=" +
                URLEncoder.encode("https://mydomain.com:4444/dlr", "UTF-8") +
                "&dlrMethod=GET&customData=customData&sendAt=2023-02-13T21:40:00.000Z";
        
        Request request = new Request.Builder()
                .url(encodedURL)
                .method("GET", null)
                .build();
        
        Response response = client.newCall(request).execute();
        String responseBody = response.body().string();
        System.out.println(responseBody);
    }
}
