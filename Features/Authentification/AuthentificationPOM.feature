Feature: AuthentificationPOM
		En tant qu'utilisateur 
     Je souhaite vérifier si la fonctionnalité d'authentification fonctionne


Scenario Outline: AuthentificationPOM
	Given Ouvrir le Site Alissia
	When Saisir le Company Login '<loginCompany>'
	And Saisir le Username '<username>' 
	And  Saisir Mot de passe '<motdepasse>'
	When Appuyer sur le bouton Connexion
	Then Redirection à la page Home

	Examples:
	| loginCompany | username | motdepasse |
	| Moncey       | ZiedH    | U74Xvp2Fq  |
	| Moncey       | ZiedH    | U74Xvp2Fq  |
