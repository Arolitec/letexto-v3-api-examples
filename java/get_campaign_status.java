//replace with your own values

OkHttpClient client = new OkHttpClient().newBuilder()
  .build();
MediaType mediaType = MediaType.parse("text/plain");
RequestBody body = RequestBody.create(mediaType, "");
Request request = new Request.Builder()
  .url("http://localhost:3333/v1/campaigns/1/status")
  .method("GET", body)
  .addHeader("Authorization", "Bearer dc408be00542eed70f4e7d1336d9a38735e5fa74")
  .build();
Response response = client.newCall(request).execute();