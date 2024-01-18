import requests

url = "<REPLACE_WITH_PROD_URL>/v1/messages/<YOUR MESSAGE ID>/status?token=<YOUR TOKEN>"

response = requests.get(url)
data = response.content.decode("utf-8")
print(data)
