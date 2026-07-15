<?php
// Replace the following values with your own
$prodUrl = '<REPLACE_WITH_PROD_URL>';
$token = '<REPLACE_WITH_YOUR_API_KEY>';

$headers = [
    'Authorization: Bearer ' . $token,
    'Content-Type: application/json'
];
$body = '{
  "label": "My WhatsApp Campaign",
  "sender": "My Company",
  "templateName": "order_confirmation",
  "contacts": ["2250000000000", "2250000000001", "2250000000002"],
  "parameters": ["John", "12345"],
  "mediaUrl": "https://mydomain.com/image.jpg",
  "notifyUrl": "https://mydomain.com:4444/dlr",
  "skipDuplicates": true,
  "sendAt": "2026-07-20T21:40:00.000Z"
}';

$ch = curl_init($prodUrl . '/v1/campaigns/whatsapp');
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
