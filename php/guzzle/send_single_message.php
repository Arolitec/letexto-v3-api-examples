<?php
// GUZZLE
// Make sure to install Guzzle using Composer: composer require guzzlehttp/guzzle

use GuzzleHttp\Client;
use GuzzleHttp\Psr7\Request;

// Replace the following values with your own
$prodUrl = '<REPLACE_WITH_PROD_URL>';
$token = '<YOUR_TOKEN>';
$from = 'SMS INFO';
$to = '2250000000000';
$content = 'Hello API!';
$dlrUrl = 'https://mydomain.com:4444/dlr';
$customData = 'customData';
$sendAt = '2023-02-13T21:40:00.000Z';

$client = new Client();

$url = $prodUrl . '/v1/messages/send?from=' . urlencode($from) .
    '&to=' . $to . '&content=' . urlencode($content) .
    '&token=' . $token . '&dlrUrl=' . urlencode($dlrUrl) .
    '&dlrMethod=GET&customData=' . $customData .
    '&sendAt=' . urlencode($sendAt);

$request = new Request('GET', $url);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
