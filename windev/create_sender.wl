requete est une restRequête

requete.Méthode		= httpPost
token est une chaîne = "<YOUR_TOKEN>"
requete.URL			= <REPLACE_WITH_PROD_URL>/v1/senders/create"
requete.ContentType	= "application/json"
requete.Entête["Authorization"] = "Bearer " + token

body est une chaîne = [
	{
	"name": "My Sender"
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
