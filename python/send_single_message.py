#replace with your own values

import http.client

conn = http.client.HTTPSConnection("localhost", 3333)
payload = ''
headers = {}
conn.request("GET", "/v1/messages/send?from=SMS%20INFO&to=225058743342&content=Hello%20API!&username=TR_c20c7c07429&password=1ad05b50&dlrUrl=https://mydomain.com:4444/dlr&dlrMethod=GET&customData=customData&sendAt=2023-02-13T21:40:00.000Z", payload, headers)
res = conn.getresponse()
data = res.read()
print(data.decode("utf-8"))