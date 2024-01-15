<?php
// Replace the following values with your own
$prodUrl = '<REPLACE_WITH_PROD_URL>';
$token = '<YOUR_TOKEN>';
$from = 'SMS INFO';
$to = '2250000000000';
$content = 'Hello API!';
$dlrUrl = 'https://mydomain.com:4444/dlr';
$customData = 'customData';
$sendAt = '2023-02-13T21:40:00.000Z';

$headers = [
    'Authorization: Bearer ' . $token,
    'Content-Type: application/json'
];

$url = $prodUrl . '/v1/messages/send?from=' . urlencode($from) .
       '&to=' . $to .
       '&content=' . urlencode($content) .
       '&token=' . $token .
       '&dlrUrl=' . urlencode($dlrUrl) .
       '&dlrMethod=GET&customData=' . $customData .
       '&sendAt=' . urlencode($sendAt);

$ch = curl_init($url);
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
curl_setopt($ch, CURLOPT_HTTPHEADER, $headers);

$response = curl_exec($ch);

if($response === false)
{
    echo 'Curl error: ' . curl_error($ch);
}
else
{
    echo $response;
}

curl_close($ch);
