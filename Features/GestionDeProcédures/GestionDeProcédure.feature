Feature: GestionDeProcédure
	En tant qu'utilisateur de l'application Alissia
	Je souhaite gérer des dossiers afin de vérifier que la gestion des procédures fonctionne

	Background: Authentification

	Given naviguer à l'application 
	When entrer le company login 'Moncey'
	And entrer le username 'ZiedH'
	And  entrer le mot de passe 'U74Xvp2Fq'
	When cliquer sur Connexion
	Then utilisateur connecté à l'application

@mytag
Scenario: Recherche Dossier existant
	Given Selectionner 'Brevets' dans la liste de recherche
	When Saisir 'BRE10003' dans la zonne de recherche 
	And cliquer Entrer
	Then La référence du dossier est bien 'BRE10003'


Scenario: Traitement dossier
	Given Selectionner 'Brevets' dans la liste de recherche
	When Saisir 'BRE10003' dans la zonne de recherche 
	And cliquer Entrer
	And Cliquer sur Procédure
	And Cliquer sur Avis de dépôt
	And Cliquer sur MAJ Date & N° dépôt ETR/NAT
	And Cliquer sur Ajouter une date priorité
	And Saisir la date '10022008'
	And Cliquer sur Pays
	And Saisir 'FR' dans le champ code
	And Cliquer sur le bouton Valider pour ajouter le pays
	And Saisir '585853' dans le champ Numéro
	And Cliquer sur le bouton Suivant
	And Modifier la date de dépôt par '15122008'
	And modifier le numéro de dépôt par '2565'
	And Cliquer sur le bouton Suivant
	And Cliquer sur le bouton modifier
	And Modifier le nom abrégé par 'BERENICE'
	And Cliquer sur le bouton de validation du modification
	And Cliquer sur le bouton Suivant
	And Cliquer sur le bouton Suivant
	And Saisir nom abrégé inexistant '123456' dans le champ Nom abrégé
	Then Une notification est affichée

	When Cliquer sur le bouton Suivant
	Then Le le correspondant annuités 'ACUMASS' est affiché dans le champ Nom abrégé

	When Cliquer sur le bouton Suivant
	Then '17' est affiché pour le nombre de pages revendications

	When Cliquer sur la valeur du nombre de mots de la description
	And Saisir '400' dans le champ valeur
	And Cliquer sur le bouton Suivant
	And Décocher la case Lancer l'étape suivante
	And Cliquer sur le bouton Terminer
	Then Etape 'Avis de dépôt >> MAJ Date & N° dépôt ETR/NAT' est bien affichée dans historique

	When Cliquer sur Dossier
	Then les informations date: '10/02/2008' et pays: 'FRANCE' et numéro: '585853' sont bien affichées pour la date priorité
	And les informations date: '15/12/2008' et pays: 'ETATS-UNIS D'AMERIQUE' et numéro: '2565' sont bien affichées pour la date dépôt
	And Le tiers 'BERENICE' est affiché pour Donneur d'ordre Annuités
	And Le tiers 'LEVIS' est affiché pour Tiers comptable
	And Le tiers 'BACON THOMAS' est affiché pour Correspondant
	And Le tiers 'ACUMASS' est affiché pour Corresp. Annuité