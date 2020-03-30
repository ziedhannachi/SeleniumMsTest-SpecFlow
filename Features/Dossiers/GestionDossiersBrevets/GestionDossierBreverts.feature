Feature: GestionDossierBreverts
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

	Background: Connecter à Alissia
		Given naviguer à l'application Alissia Formation
		When entrer le company login 'Moncey'
		And entrer le username 'ZiedH'
		And  entrer le mot de passe 'U74Xvp2Fq'
		When cliquer sur Connexion
		Then utilisateur connecté à l'application et la page d'accueil est affichée

	Scenario: Création d’un dossier_brevet 
		Given Cliquer dans l’onglet Dossiers 
		And Cliquer sur dossier Breverts
		And Cliquer sur Nouveau
		When Sélectionner Brevet français d’origine française dans le champ Prestation
		And Cliquer sur Titre abrégé de la ligne créée
		And Saisir 'DOSSIER BADOIT'
		And Cliquer sur Titre de la ligne créée
		And Saisir 'DOSSIER BADOIT COMPLET' dand le champ Titre
		And Cliquer sur Suivant du popup
		And Cliquer sur le bouton Ajouter un tiers Donneurs d'ordre
		And Saisir 'BADOIT' dans Nom abrégé
		And cliquer Entrer
		And Cliquer sur le bouton Suivant
		And Cliquer sur le bouton Suivant
		And Cliquer sur le bouton Suivant
		And Cliquer sur le bouton Ajouter un tiers inventeur
		And Saisir 'PETIT' dans Nom abrégé
		#And cliquer Entrer
		#And Cliquer sur le bouton Suivant
		#And Cliquer sur le bouton Suivant
		#And Cliquer sur le bouton Terminer

