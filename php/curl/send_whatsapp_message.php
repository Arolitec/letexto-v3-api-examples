<?php
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

$ch = curl_init($prodUrl . '/v1/whatsapp/send');

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
