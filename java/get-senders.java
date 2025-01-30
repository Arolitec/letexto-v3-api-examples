import okhttp3.*;
import java.io.IOException;

public class Main {
    public static void main(String[] args) throws IOException {
        OkHttpClient client = new OkHttpClient().newBuilder().build();

        HttpUrl.Builder urlBuilder = HttpUrl.parse("<REPLACE_WITH_PROD_URL>/v1/senders").newBuilder();
        urlBuilder.addQueryParameter("query", "searchTerm");        
        urlBuilder.addQueryParameter("status", "PENDING");         
        urlBuilder.addQueryParameter("allAccounts", "true");      

        Request request = new Request.Builder()
                .url(urlBuilder.build())
                .method("GET", null)
                .addHeader("Authorization", "Bearer <REPLACE_WITH_YOUR_API_KEY>")
                .addHeader("Content-Type", "application/json")
                .build();

        Response response = client.newCall(request).execute();
        String responseBody = response.body().string();
        System.out.println(responseBody);
    }
}