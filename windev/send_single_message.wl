requete est une restRequête

requete.Méthode = restMéthodePOST
requete.URL = "<REPLACE_WITH_PROD_URL>/v1/messages/send"
requete.AjouteEnTête("Authorization", "Bearer <REPLACE_WITH_YOUR_API_KEY>")
requete.AjouteEnTête("Content-Type", "application/json")

corpsJSON est une chaîne = [
    "from": "SOSSO",
    "to": "2250000000000",
    "content": "Hello API!",
    "dlrUrl": "https://mydomain.com:4444/dlr",
    "dlrMethod": "GET",
    "customData": "customData",
    "sendAt": "2023-02-13T21:40:00.000Z"
]

requete.AjouteCorps(corpsJSON, restFormatJSON)

requeteReponse est une restRéponse = RESTEnvoie(requete)

SI ErreurDétectée ALORS
    ErreurInfo(errComplet)
SINON
    Info(requeteReponse.Contenu)
FIN