requete est une restRequête

requete.Méthode	= httpGet
requete.URL		= "https://apis-test.letexto.com/v1/message/<YOUR_MESSAGE_ID>/status?token=<REPLACE_WITH_YOUR_API_KEY>"
requeteReponse est une restRéponse = RESTEnvoie(requete)

SI ErreurDétectée ALORS
	Erreur(ErreurInfo(errComplet))
SINON
	Info(requeteReponse.Contenu)
FIN
