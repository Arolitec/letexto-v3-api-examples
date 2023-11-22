<?php
// GUZZLE
// Make sure to install Guzzle using Composer: composer require guzzlehttp/guzzle

use GuzzleHttp\Client;
use GuzzleHttp\Psr7\Request;

// Replace the following values with your own
$prodUrl = '<REPLACE_WITH_PROD_URL>';
$token = '<YOUR_TOKEN>';

$client = new Client();

$body = '';
$request = new Request('GET', $prodUrl . '/v1/users/balance?token=<REPLACE_WITH_YOUR_MESSAGE_ID>', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();

