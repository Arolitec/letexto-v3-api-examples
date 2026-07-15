requete est une restRequête

requete.Méthode	= httpGet
requete.URL		= "<REPLACE_WITH_PROD_URL>/v1/campaigns/whatsapp/<YOUR_CAMPAIGN_ID>/status?token=<REPLACE_WITH_YOUR_API_KEY>"
requeteReponse est une restRéponse = RESTEnvoie(requete)

SI ErreurDétectée ALORS
	Erreur(ErreurInfo(errComplet))
SINON
	Info(requeteReponse.Contenu)
FIN
