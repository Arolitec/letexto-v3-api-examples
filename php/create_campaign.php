<!--php GUZZLE-->
<!--replace with your own values-->

<?php
$client = new Client();
$headers = [
  'Authorization' => 'Bearer dc408be00542eed70f4e7d1336d9a38735e5fa74',
  'Content-Type' => 'application/json'
];
$body = '{
  "label": "My Campaign publipostage",
  "sender": "AROLITEC",
  "contacts": [
    {
      "age": "12",
      "numero": "22507479171",
      "name": "Martial"
    },
    {
      "age": "24",
      "numero": "22507051918",
      "name": "Rita"
    },
    {
      "age": "32",
      "numero": "225068275212",
      "name": "Arolitec"
    }
  ],
  "content": "Hello {{name}}, votre numéro est {{numero}}"
}';
$request = new Request('POST', 'http://localhost:3333/v1/campaigns', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
