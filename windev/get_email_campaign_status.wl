requete est une restRequête

requete.Méthode	= httpGet
requete.URL		= "https://apis-test.letexto.com/v1/campaigns/emails/<CAMPAIGN_ID>/status?token=<REPLACE_WITH_YOUR_API_KEY>"
requeteReponse est une restRéponse = RESTEnvoie(requete)

SI ErreurDétectée ALORS
	Erreur(ErreurInfo(errComplet))
SINON
	Info(requeteReponse.Contenu)
FIN
