requete est une restRequête

requete.Méthode		= httpPost
token est une chaîne = "<YOUR_TOKEN>"
requete.URL			= <REPLACE_WITH_PROD_URL>/v1/campaigns/emails"
requete.ContentType	= "application/json"
requete.Entête["Authorization"] = "Bearer " + token

body est une chaîne = [
	{
	"label": "My Campaign",
    "from": "sender@mail.com",
    "recipients": ["test@mail.com", "test@mail.com", "test@mail.com"],
    "subject": "subject",
	"content": "Hello",
	}
]

Info(ChaîneVersJSON(body))

requete.Contenu	= body
cTest1Reponse est une restRéponse = RESTEnvoie(requete)

SI ErreurDétectée ALORS
	Erreur(ErreurInfo(errComplet))
SINON
	Info(cTest1Reponse.Contenu)
FIN
