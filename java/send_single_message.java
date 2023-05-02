OkHttpClient client = new OkHttpClient().newBuilder()
  .build();
MediaType mediaType = MediaType.parse("text/plain");
RequestBody body = RequestBody.create(mediaType, "");
Request request = new Request.Builder()
  .url("http://localhost:3333/v1/messages/send?from=SMS INFO&to=22505854342&content=Hello API!&username=TR_c20c7c07429&password=1ad05b50&dlrUrl=https://mydomain.com:4444/dlr&dlrMethod=GET&customData=customData&sendAt=2023-02-13T21:40:00.000Z")
  .method("GET", body)
  .build();
Response response = client.newCall(request).execute();