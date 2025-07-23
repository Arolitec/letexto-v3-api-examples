<?php

use GuzzleHttp\Client;
use GuzzleHttp\Psr7\Request;

$prodUrl = '<REPLACE_WITH_PROD_URL>';
$token = '<YOUR_TOKEN>';

$data = [
    'from' => 'SMS INFO',
    'to' => '2250000000000',
    'content' => 'Hello API!',
    'dlrUrl' => 'https://mydomain.com:4444/dlr',
    'dlrMethod' => 'GET',
    'customData' => 'customData',
    'sendAt' => '2023-02-13T21:40:00.000Z'
];

$client = new Client([
    'headers' => [
        'Authorization' => 'Bearer ' . $token,
        'Content-Type' => 'application/json',
        'Accept' => 'application/json'
    ]
]);

try {
    $response = $client->post($prodUrl . '/v1/messages/send', [
        'json' => $data
    ]);
    
    echo $response->getBody();
} catch (\GuzzleHttp\Exception\RequestException $e) {
    echo 'Error: ' . $e->getMessage();
    if ($e->hasResponse()) {
        echo ' - ' . $e->getResponse()->getBody();
    }
}