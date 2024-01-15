<?php
// Replace the following values with your own
$prodUrl = '<REPLACE_WITH_PROD_URL>';
$token = '<YOUR_TOKEN>';

$headers = [
    'Authorization: Bearer ' . $token,
    'Content-Type: application/json'
];
$body = '{
  "name": "My Sender"
}';

$ch = curl_init($prodUrl . '/v1/senders/create');
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
curl_setopt($ch, CURLOPT_POST, true);
curl_setopt($ch, CURLOPT_HTTPHEADER, $headers);
curl_setopt($ch, CURLOPT_POSTFIELDS, $body);

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
