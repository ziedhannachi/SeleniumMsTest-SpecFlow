Feature: Recherche
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

	Background: Authentification

	Given naviguer à l'application 
	When entrer le company login 'Moncey'
	And entrer le username 'ZiedH'
	And  entrer le mot de passe 'U74Xvp2Fq'
	When cliquer sur Connexion
	Then utilisateur connecté à l'application

@RechercheDossier
Scenario: Recheche avec nom dossier introuvable
	When Saisir un nom du dossier inexistant 'ssgsgh'
	When cliquer Entrer
	Then La page Home reste affichée

@RechercheDossier
Scenario Outline: Recheche avancée - Recherche Dossier
	When Cliquer sur le bouton recherche avancée
	And Cliquer sur Tiers
	And Cliquer sur Donneur d'ordre
	And Cliquer sur le bouton Donneur D'ordre
	And Cliquer sur le bouton égale à 
	And Saisir la valeur 'P & L'
	And Cliquer sur le bouton Valider
	And Cliquer sur le bouton Recherche
	Then Vérification du temps d'affichage du résultat et La liste des informations est affiché
	And Execution scénarion numéro "<id>"
	Examples:
	| id |
	| 1  |
	| 2  |
	| 3  |

Scenario: Recheche avancée - Drag and Drop
	When Cliquer sur le bouton recherche avancée
	And Cliquer sur Tiers
	And Cliquer sur Donneur d'ordre
	And Cliquer sur le bouton Donneur D'ordre
	And Cliquer sur le bouton égale à 
	And Saisir la valeur 'P & L'
	And Cliquer sur le bouton Valider
	And Cliquer sur le bouton Recherche
	And Cliquer sur le bouton Paramétrage des colonnes
	And Glisser Statut dans la colonne Colonnes sélectionnées
	And Cliquer sur le bouton Sauvegarder
	Then La colone Statut doit être affichée dans le tableau

Scenario: Recheche avancée - 
	When Cliquer sur le bouton recherche avancée
	And Cliquer sur Tiers
	And Cliquer sur Donneur d'ordre
	And Cliquer sur le bouton Donneur D'ordre
	And Cliquer sur le bouton égale à 
	And Saisir la valeur 'P & L'
	And Cliquer sur le bouton Valider
	And Cliquer sur le bouton Recherche
	And Cliquer sur le bouton Sauvegarder la requête
	And Cliquer sur Sauvegarder
	And Cliquer sur le bouton Fermer
	And Accéder à la page dossier
	Then  La requête est affiché dans la la partie Mes requêtes
