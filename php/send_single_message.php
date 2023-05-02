<!--GUZZLE-->
<!--replace with your own values-->

<?php
$client = new Client();
$request = new Request('GET', 'http://localhost:3333/v1/messages/send?from=SMS INFO&to=22505874342&content=Hello API!&username=TR_c20c7c07429&password=1ad05b50&dlrUrl=https://mydomain.com:4444/dlr&dlrMethod=GET&customData=customData&sendAt=2023-02-13T21:40:00.000Z');
$res = $client->sendAsync($request)->wait();
echo $res->getBody();

