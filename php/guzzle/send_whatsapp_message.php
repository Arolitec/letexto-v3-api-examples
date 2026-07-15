<?php
// GUZZLE
// Make sure to install Guzzle using Composer: composer require guzzlehttp/guzzle

use GuzzleHttp\Client;

$prodUrl = '<REPLACE_WITH_PROD_URL>';
$token = '<REPLACE_WITH_YOUR_API_KEY>';

$data = [
    'from' => 'My Company',
    'to' => '2250000000000',
    'templateName' => 'order_confirmation',
    'parameters' => ['John', '12345'],
    'mediaUrl' => 'https://mydomain.com/image.jpg',
    'notifyUrl' => 'https://mydomain.com:4444/dlr'
];

$client = new Client([
    'headers' => [
        'Authorization' => 'Bearer ' . $token,
        'Content-Type' => 'application/json',
        'Accept' => 'application/json'
    ]
]);

try {
    $response = $client->post($prodUrl . '/v1/whatsapp/send', [
        'json' => $data
    ]);

    echo $response->getBody();
} catch (\GuzzleHttp\Exception\RequestException $e) {
    echo 'Error: ' . $e->getMessage();
    if ($e->hasResponse()) {
        echo ' - ' . $e->getResponse()->getBody();
    }
}
