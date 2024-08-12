<?php
// Replace the following values with your own
$prodUrl = '<REPLACE_WITH_PROD_URL>';
$token = '<REPLACE_WITH_YOUR_API_KEY>';

$headers = [
    'Authorization: Bearer ' . $token,
    'Content-Type: application/json'
];
$body = '{
    "label": "My Campaign publipostage",
    "from": "sender@mail.com",
    "recipients": ["test@mail.com", "test@mail.com", "test@mail.com"],
    "content": "Hello {{name}}, votre numéro est {{numero}}",
    "subject": "subject",
   }';

$ch = curl_init($prodUrl . '/v1/campaigns/emails');
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
