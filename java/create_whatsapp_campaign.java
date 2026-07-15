import okhttp3.*;

import java.io.IOException;

public class Main {
    public static void main(String[] args) throws IOException {
        OkHttpClient client = new OkHttpClient().newBuilder().build();

        MediaType mediaType = MediaType.parse("application/json");
        RequestBody body = RequestBody.create(mediaType, "{\n" +
                "    \"label\": \"My WhatsApp Campaign\",\n" +
                "    \"sender\": \"My Company\",\n" +
                "    \"templateName\": \"order_confirmation\",\n" +
                "    \"contacts\": [\"2250000000000\", \"2250000000001\", \"2250000000002\"],\n" +
                "    \"parameters\": [\"John\", \"12345\"],\n" +
                "    \"mediaUrl\": \"https://mydomain.com/image.jpg\",\n" +
                "    \"notifyUrl\": \"https://mydomain.com:4444/dlr\",\n" +
                "    \"skipDuplicates\": true,\n" +
                "    \"sendAt\": \"2026-07-20T21:40:00.000Z\"\n" +
                "}");

        Request request = new Request.Builder()
                .url("<REPLACE_WITH_PROD_URL>/v1/campaigns/whatsapp")
                .method("POST", body)
                .addHeader("Authorization", "Bearer <REPLACE_WITH_YOUR_API_KEY>")
                .addHeader("Content-Type", "application/json")
                .build();

        Response response = client.newCall(request).execute();
        String responseBody = response.body().string();
        System.out.println(responseBody);
    }
}
