requete est une restRequête

requete.Méthode	= httpGet
requete.Entête["Authorization"] = "Bearer <YOUR_TOKEN>"
requete.URL		= "https://apis-test.letexto.com/v1/campaigns/sms/<CAMPAIGN_ID>/status"
requeteReponse est une restRéponse = RESTEnvoie(requete)

SI ErreurDétectée ALORS
	Erreur(ErreurInfo(errComplet))
SINON
	Info(requeteReponse.Contenu)
FIN
