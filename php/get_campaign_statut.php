<?php
$client = new Client();
$headers = [
  'Authorization' => 'Bearer dc408be00542eed70f4e7d1336d9a38735e5fa74'
];
$body = '';
$request = new Request('GET', 'http://localhost:3333/v1/campaigns/1/status', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
