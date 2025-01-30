requete est une restRequête

requete.Méthode = httpGet
token est une chaîne = "<YOUR_TOKEN>"

params est une chaîne
params += "?query=searchTerm"        
params += "&status=PENDING"          
params += "&allAccounts=true"        

requete.URL = "<REPLACE_WITH_PROD_URL>/v1/senders" + params
requete.ContentType = "application/json"
requete.Entête["Authorization"] = "Bearer " + token

cTest1Reponse est une restRéponse = RESTEnvoie(requete)

SI ErreurDétectée ALORS
    Erreur(ErreurInfo(errComplet))
SINON
    Info(cTest1Reponse.Contenu)
FIN