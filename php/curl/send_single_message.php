<?php
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

$ch = curl_init($prodUrl . '/v1/messages/send');

curl_setopt_array($ch, [
    CURLOPT_RETURNTRANSFER => true,
    CURLOPT_POST => true,
    CURLOPT_HTTPHEADER => [
        'Authorization: Bearer ' . $token,
        'Content-Type: application/json'
    ],
    CURLOPT_POSTFIELDS => json_encode($data)
]);

$response = curl_exec($ch);

if(curl_errno($ch)) {
    echo 'Erreur cURL : ' . curl_error($ch);
} else {
    $httpCode = curl_getinfo($ch, CURLINFO_HTTP_CODE);
    if($httpCode >= 400) {
        echo "Erreur HTTP $httpCode : " . $response;
    } else {
        echo $response;
    }
}

curl_close($ch);
?>