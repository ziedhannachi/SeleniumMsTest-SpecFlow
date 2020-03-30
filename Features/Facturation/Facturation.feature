Feature: Facturation
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

Scenario: Facturation
	Given Selectionner 'Brevets' dans la liste de recherche
	When Saisir 'BRE10016' dans la zonne de recherche 
	And cliquer Entrer
	And Cliquer sur Procédure
	And Cliquer sur le checkBox procédure
	And Cliquer sur l'étape Avis de dépôts
	And Cliquer sur Valorisation DEPOT
	And Cliquer sur le bouton Terminer
	And Cliquer sur Val/Fac
	Then La valorisation est bien présente dans En cours

	When Cliquer sur la Valorisation DEPOT
	Then '4 000,00 EUR' est affiché pour le total du libellé dépôt en ligne

	When Cliquer sur l'état du libellé Envoi recommandé 
	And Modifier l'état à non facturable
	And Modifier la taxe du libellé Forfait administratif du dépôt à '250' EUR pour valorisation
	And Cliquer sur bouton Sauvegarder
	And Cliquer sur le checkBox Facturation
	And Modifier la taxe du libellé Forfait administratif du dépôt à '100' EUR pour Facturation
	And Cliquer sur bouton Sauvegarder
	Then La ligne Forfait administratif du dépôt est en gras

	When Cliquer sur le bouton Export cognos
	And Cliquer sur le bouton télécharger le fichier
	Then Le fichier doit être téléchargé

	When Cliquer sur l'icone Facturation
	And Cliquer sur le bouton Facturation
	Then '1 455,00' euros est le total des frais et honoraires pour le tiers 'LEVIS'

	When Cliquer sur le bouton Modifier
	And Déplacer la section Taxes officielles
	And Cliquer sur le bouton valider
	Then La section Taxes officielles est bien déplacé

	When Cliquer sur Générer un courrier
	And Cliquer sur Facture/Débit - Avoir/Crédit
	And Cliquer sur le bouton Suivant du pop up Générer un courrier
	And Sélectionner la langue Français
	And Cliquer suivant
	And Cliquer sur Générer le document
	And  Cliquer sur l'icone Word
	Then Le document word s'ouvre
	

