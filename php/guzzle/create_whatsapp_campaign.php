<?php
// GUZZLE
// Make sure to install Guzzle using Composer: composer require guzzlehttp/guzzle

use GuzzleHttp\Client;
use GuzzleHttp\Psr7\Request;

// Replace the following values with your own
$prodUrl = '<REPLACE_WITH_PROD_URL>';
$token = '<REPLACE_WITH_YOUR_API_KEY>';

$client = new Client();
$headers = [
    'Authorization' => 'Bearer ' . $token,
    'Content-Type' => 'application/json'
];
$body = '{
  "label": "My WhatsApp Campaign",
  "sender": "My Company",
  "templateName": "order_confirmation",
  "contacts": ["2250000000000", "2250000000001", "2250000000002"],
  "parameters": ["John", "12345"],
  "mediaUrl": "https://mydomain.com/image.jpg",
  "notifyUrl": "https://mydomain.com:4444/dlr",
  "skipDuplicates": true,
  "sendAt": "2026-07-20T21:40:00.000Z"
}';
$request = new Request('POST', $prodUrl . '/v1/campaigns/whatsapp', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
