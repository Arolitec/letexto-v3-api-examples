import requests
import json

url = "<REPLACE_WITH_PROD_URL>/v1/campaigns"
payload = json.dumps({
  "label": "My Campaign publipostage",
  "sender": "AROLITEC",
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
      "name": "Arolitec"
    }
  ],
  "content": "Hello {{name}}, votre numéro est {{numero}}"
})
headers = {
  'Authorization': 'Bearer <YOUR_TOKEN>',
  'Content-Type': 'application/json'
}

response = requests.post(url, data=payload, headers=headers)
data = response.json()
print(json.dumps(data))
