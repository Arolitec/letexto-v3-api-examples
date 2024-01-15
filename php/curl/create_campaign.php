<?php
// Replace the following values with your own
$prodUrl = '<REPLACE_WITH_PROD_URL>';
$token = '<YOUR_TOKEN>';

$headers = [
    'Authorization: Bearer ' . $token,
    'Content-Type: application/json'
];
$body = '{
  "label": "My Campaign publipostage",
  "sender": "SMS INFO",
  "contacts": [
    {
      "age": "12",
      "numero": "2250000000000",
      "name": "Martial"
    },
    {
      "age": "24",
      "numero": "2250000000000",
      "name": "Rita"
    },
    {
      "age": "32",
      "numero": "2250000000000",
      "name": "John"
    }
  ],
  "content": "Hello {{name}}, votre numéro est {{numero}}"
}';

$ch = curl_init($prodUrl . '/v1/campaigns');
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
