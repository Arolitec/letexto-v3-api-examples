requete est une restRequête

requete.Méthode = restMéthodePOST
requete.URL = "<REPLACE_WITH_PROD_URL>/v1/whatsapp/send"
requete.AjouteEnTête("Authorization", "Bearer <REPLACE_WITH_YOUR_API_KEY>")
requete.AjouteEnTête("Content-Type", "application/json")

corpsJSON est une chaîne = [
    "from": "My Company",
    "to": "2250000000000",
    "templateName": "order_confirmation",
    "parameters": ["John", "12345"],
    "mediaUrl": "https://mydomain.com/image.jpg",
    "notifyUrl": "https://mydomain.com:4444/dlr"
]

requete.AjouteCorps(corpsJSON, restFormatJSON)

requeteReponse est une restRéponse = RESTEnvoie(requete)

SI ErreurDétectée ALORS
    ErreurInfo(errComplet)
SINON
    Info(requeteReponse.Contenu)
FIN
