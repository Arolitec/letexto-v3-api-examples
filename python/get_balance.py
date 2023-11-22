import requests

url = "<REPLACE_WITH_PROD_URL>/v1/users/balance?token=<REPLACE_WITH_YOUR_MESSAGE_ID>"

response = requests.get(url, headers=headers)
data = response.content.decode("utf-8")
print(data)
