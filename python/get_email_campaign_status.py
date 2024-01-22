import requests

url = "<REPLACE_WITH_PROD_URL>/v1/campaigns/emails/<YOUR_CAMPAIGN_ID>/status?token=<REPLACE_WITH_YOUR_API_KEY>"

headers = {}

response = requests.get(url, headers=headers)
data = response.content.decode("utf-8")
print(data)
