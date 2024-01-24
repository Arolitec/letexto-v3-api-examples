<?php
// GUZZLE
// Make sure to install Guzzle using Composer: composer require guzzlehttp/guzzle

use GuzzleHttp\Client;
use GuzzleHttp\Psr7\Request;

// Replace the following values with your own
$prodUrl = '<REPLACE_WITH_PROD_URL>';
$token = '<REPLACE_WITH_YOUR_API_KEY>';
$messageId = '<YOUR_MESSAGE_ID>';

$client = new Client();

$request = new Request('GET', $prodUrl . '/v1/messages/'+ $messageId +'/status?token=' + $token);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
