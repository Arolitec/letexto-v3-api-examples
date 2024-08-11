import requests
import json

url = "<REPLACE_WITH_PROD_URL>/v1/campaigns/emails"
payload = json.dumps({
  "label": "My Campaign publipostage",
    "from": "sender@mail.com",
    "recipients": ["test1@mail.com", "test2@mail.com", "test3@mail.com"],
    "content": "Hello {{name}}, votre numéro est {{numero}}",
    "subject": "subject",
})
headers = {
  'Authorization': 'Bearer <REPLACE_WITH_YOUR_API_KEY>',
  'Content-Type': 'application/json'
}

response = requests.post(url, data=payload, headers=headers)
data = response.json()
print(json.dumps(data))
