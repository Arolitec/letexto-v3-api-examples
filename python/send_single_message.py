import requests

url = "<REPLACE_WITH_PROD_URL>/v1/messages/send?from=SMS%20INFO&to=225058743342&content=Hello%20API!&token=<REPLACE_WITH_YOUR_API_KEY>&dlrUrl=https://mydomain.com:4444/dlr&dlrMethod=GET&customData=customData&sendAt=2023-02-13T21:40:00.000Z"
headers = {}

response = requests.get(url, headers=headers)
data = response.content.decode("utf-8")
print(data)
