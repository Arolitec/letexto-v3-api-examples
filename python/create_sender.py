import requests
import json

url = "<REPLACE_WITH_PROD_URL>/v1/senders/create"
payload = json.dumps({
  "name": "My Sender"
})
headers = {
  'Authorization': 'Bearer <YOUR_TOKEN>',
  'Content-Type': 'application/json'
}

response = requests.post(url, data=payload, headers=headers)
data = response.json()
print(json.dumps(data))
