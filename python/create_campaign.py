#replace with your own values

import http.client
import json

conn = http.client.HTTPSConnection("localhost", 3333)
payload = json.dumps({
  "label": "My Campaign publipostage",
  "sender": "AROLITEC",
  "contacts": [
    {
      "age": "12",
      "numero": "225074189171",
      "name": "Martial"
    },
    {
      "age": "24",
      "numero": "225070865918",
      "name": "Rita"
    },
    {
      "age": "32",
      "numero": "225076825212",
      "name": "Arolitec"
    }
  ],
  "content": "Hello {{name}}, votre numéro est {{numero}}"
})
headers = {
  'Authorization': 'Bearer dc408be00542eed70f4e7d1336d9a38735e5fa74',
  'Content-Type': 'application/json'
}
conn.request("POST", "/v1/campaigns", payload, headers)
res = conn.getresponse()
data = res.read()
print(data.decode("utf-8"))