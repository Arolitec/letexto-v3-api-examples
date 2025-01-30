import requests
import json

url = "<REPLACE_WITH_PROD_URL>/v1/senders"

params = {
    "query": "searchTerm",        
    "status": "PENDING",         
    "allAccounts": "true"       
}

headers = {
    'Authorization': 'Bearer <REPLACE_WITH_YOUR_API_KEY>',
    'Content-Type': 'application/json'
}

response = requests.get(url, params=params, headers=headers)
data = response.json()
print(json.dumps(data))