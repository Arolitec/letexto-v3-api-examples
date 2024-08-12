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
  "label": "My Campaign publipostage",
    "from": "sender@mail.com",
    "recipients": ["test@mail.com", "test@mail.com", "test@mail.com"],
    "content": "Hello {{name}}, votre numéro est {{numero}}",
    "subject": "subject",
}';
$request = new Request('POST', $prodUrl . '/v1/campaigns/emails', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();

