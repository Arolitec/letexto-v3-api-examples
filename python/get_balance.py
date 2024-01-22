import requests

url = "<REPLACE_WITH_PROD_URL>/v1/users/balance?token=<REPLACE_WITH_YOUR_API_KEY>"

response = requests.get(url)
data = response.content.decode("utf-8")
print(data)
