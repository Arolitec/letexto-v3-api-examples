import requests

url = "<REPLACE_WITH_PROD_URL>/v1/messages/send"
token = "<REPLACE_WITH_YOUR_API_KEY>"

response = requests.post(
    url,
    headers={
        "Authorization": f"Bearer {token}"
    },
    json={
        "from": "SMS INFO",
        "to": "225058743342",
        "content": "Hello API!",
        "dlrUrl": "https://mydomain.com:4444/dlr",
        "dlrMethod": "GET",
        "customData": "customData",
        "sendAt": "2023-02-13T21:40:00.000Z"
    }
)

print(response.text)