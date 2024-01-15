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
  "name": "My Sender"
}';
$request = new Request('POST', $prodUrl . '/v1/senders/create', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();

