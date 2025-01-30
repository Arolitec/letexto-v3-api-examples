<?php
// GUZZLE
// Make sure to install Guzzle using Composer: composer require guzzlehttp/guzzle

use GuzzleHttp\Client;
use GuzzleHttp\Psr7\Request;

$prodUrl = '<REPLACE_WITH_PROD_URL>';
$token = '<REPLACE_WITH_YOUR_API_KEY>';

$client = new Client();
$headers = [
    'Authorization' => 'Bearer ' . $token,
    'Content-Type' => 'application/json'
];

$params = [
    'query' => 'searchTerm',
    'status' => 'PENDING',
    'allAccounts' => 'true'
];

$url = $prodUrl . '/v1/senders?' . http_build_query($params);
$request = new Request('GET', $url, $headers);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();