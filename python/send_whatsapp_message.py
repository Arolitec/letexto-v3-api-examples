import requests

url = "<REPLACE_WITH_PROD_URL>/v1/whatsapp/send"
token = "<REPLACE_WITH_YOUR_API_KEY>"

response = requests.post(
    url,
    headers={
        "Authorization": f"Bearer {token}"
    },
    json={
        "from": "My Company",
        "to": "2250000000000",
        "templateName": "order_confirmation",
        "parameters": ["John", "12345"],
        "mediaUrl": "https://mydomain.com/image.jpg",
        "notifyUrl": "https://mydomain.com:4444/dlr"
    }
)

print(response.text)
