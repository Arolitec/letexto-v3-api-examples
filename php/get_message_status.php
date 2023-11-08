<?php
// GUZZLE
// Make sure to install Guzzle using Composer: composer require guzzlehttp/guzzle

use GuzzleHttp\Client;
use GuzzleHttp\Psr7\Request;

// Replace the following values with your own
$prodUrl = '<REPLACE_WITH_PROD_URL>';
$token = '<YOUR_TOKEN>';
$messageId = '<YOUR_MESSAGE_ID>';

$client = new Client();
$headers = [
    'Authorization' => 'Bearer ' . $token
];
$body = '';
$request = new Request('GET', $prodUrl . '/v1/message/'+ $messageId +'/status', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
