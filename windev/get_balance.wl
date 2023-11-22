requete est une restRequête
token est une chaîne

requete.Méthode	= httpGet
requete.URL		= "https://apis-test.letexto.com/v1/users/balance?token" + token
requeteReponse est une restRéponse = RESTEnvoie(requete)

SI ErreurDétectée ALORS
	Erreur(ErreurInfo(errComplet))
SINON
	Info(requeteReponse.Contenu)
FIN
