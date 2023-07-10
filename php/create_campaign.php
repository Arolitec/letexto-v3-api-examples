<?php
// GUZZLE
// Make sure to install Guzzle using Composer: composer require guzzlehttp/guzzle

use GuzzleHttp\Client;
use GuzzleHttp\Psr7\Request;

// Replace the following values with your own
$prodUrl = '<REPLACE_WITH_PROD_URL>';
$token = '<YOUR_TOKEN>';

$client = new Client();
$headers = [
    'Authorization' => 'Bearer ' . $token,
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
$request = new Request('POST', $prodUrl . '/v1/campaigns', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();

