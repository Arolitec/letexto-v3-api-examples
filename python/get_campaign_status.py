import requests

url = "<REPLACE_WITH_PROD_URL>/v1/campaigns/1/status"
headers = {
  'Authorization': 'Bearer <YOUR_TOKEN>'
}

response = requests.get(url, headers=headers)
data = response.content.decode("utf-8")
print(data)
