//replace with your own values

OkHttpClient client = new OkHttpClient().newBuilder()
  .build();
MediaType mediaType = MediaType.parse("application/json");
RequestBody body = RequestBody.create(mediaType, "{\n    \"label\": \"My Campaign publipostage\",\n    \"sender\": \"AROLITEC\",\n    \"contacts\": [\n        {\"age\": \"12\", \"numero\": \"2250747189171\", \"name\": \"Martial\"},\n        {\"age\": \"24\", \"numero\": \"2250708651918\", \"name\": \"Rita\"},\n        {\"age\": \"32\", \"numero\": \"225076827512\", \"name\": \"Arolitec\"}\n    ],\n    \"content\": \"Hello {{name}}, votre numéro est {{numero}}\"\n}");
Request request = new Request.Builder()
  .url("http://localhost:3333/v1/campaigns")
  .method("POST", body)
  .addHeader("Authorization", "Bearer dc408be00542eed70f4e7d1336d9a38735e5fa74")
  .addHeader("Content-Type", "application/json")
  .build();
Response response = client.newCall(request).execute();