requete est une restRequête

requete.Méthode		= httpPost
token est une chaîne = "<REPLACE_WITH_YOUR_API_KEY>"
requete.URL			= "<REPLACE_WITH_PROD_URL>/v1/campaigns/whatsapp"
requete.ContentType	= "application/json"
requete.Entête["Authorization"] = "Bearer " + token

body est une chaîne = [
	{
	"label": "My WhatsApp Campaign",
	"sender": "My Company",
	"templateName": "order_confirmation",
	"contacts": ["2250000000000", "2250000000001", "2250000000002"],
	"parameters": ["John", "12345"],
	"mediaUrl": "https://mydomain.com/image.jpg",
	"notifyUrl": "https://mydomain.com:4444/dlr",
	"skipDuplicates": true,
	"sendAt": "2026-07-20T21:40:00.000Z"
	}
]

Info(ChaîneVersJSON(body))

requete.Contenu	= body
cReponse est une restRéponse = RESTEnvoie(requete)

SI ErreurDétectée ALORS
	Erreur(ErreurInfo(errComplet))
SINON
	Info(cReponse.Contenu)
FIN
