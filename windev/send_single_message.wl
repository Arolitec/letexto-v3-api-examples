requete est une restRequête

requete.URL="<REPLACE_WITH_PROD_URL>/messages/send?from=SOSSO&to=2250000000000&content=Hello+API%21&token=<YOUR_TOKEN>&dlrUrl=https%3A%2F%2Fmydomain.com%3A4444%2Fdlr&dlrMethod=GET&customData=customData&sendAt=2023-02-13T21%3A40%3A00.000Z"
requeteReponse est une restRéponse = RESTEnvoie(requete)

SI ErreurDétectée ALORS
	ErreurInfo(errComplet)
SINON
	Info(requeteReponse.Contenu)
FIN