<?php
// Replace the following values with your own
$prodUrl = '<REPLACE_WITH_PROD_URL>';
$token = '<YOUR_TOKEN>';

$headers = [
    'Authorization: Bearer ' . $token,
    'Content-Type: application/json'
];

$ch = curl_init($prodUrl . '/v1/campaigns/1/status');
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
