requete est une restRequête

requete.Méthode	= httpGet
requete.URL		= "https://apis-test.letexto.com/v1/message/<MESSAGE_ID>/status?token=<YOUR TOKEN>"
requeteReponse est une restRéponse = RESTEnvoie(requete)

SI ErreurDétectée ALORS
	Erreur(ErreurInfo(errComplet))
SINON
	Info(requeteReponse.Contenu)
FIN
