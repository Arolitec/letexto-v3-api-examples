#replace with your own values

import http.client

conn = http.client.HTTPSConnection("localhost", 3333)
payload = ''
headers = {
  'Authorization': 'Bearer dc408be00542eed0f4e7d1336d9a38735e5fa74'
}
conn.request("GET", "/v1/campaigns/1/status", payload, headers)
res = conn.getresponse()
data = res.read()
print(data.decode("utf-8"))