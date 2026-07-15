import requests
import json

url = "<REPLACE_WITH_PROD_URL>/v1/campaigns/whatsapp"
payload = json.dumps({
  "label": "My WhatsApp Campaign",
  "sender": "My Company",
  "templateName": "order_confirmation",
  "contacts": ["2250000000000", "2250000000001", "2250000000002"],
  "parameters": ["John", "12345"],
  "mediaUrl": "https://mydomain.com/image.jpg",
  "notifyUrl": "https://mydomain.com:4444/dlr",
  "skipDuplicates": True,
  "sendAt": "2026-07-20T21:40:00.000Z"
})
headers = {
  'Authorization': 'Bearer <REPLACE_WITH_YOUR_API_KEY>',
  'Content-Type': 'application/json'
}

response = requests.post(url, data=payload, headers=headers)
data = response.json()
print(json.dumps(data))
