@Smoke
Feature: Authentification
 En tant qu'utilisateur 
     Je souhaite vérifier si la fonctionnalité d'authentification fonctionne

@Smoke
Scenario:Alissia - Authentification
Given naviguer à l'application 
When entrer le company login 'Moncey'
And entrer le username 'ZiedH'
And  entrer le mot de passe 'U74Xvp2Fq'
When cliquer sur Connexion
Then utilisateur connecté à l'application
