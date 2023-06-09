<div align = center>

![Image de l'application](CraftSharp-Logo.png)

</div>

**Nom de l’application** : Craft# 🕹
</br>

**Thème de l’application** : Répertorier son inventaire.
</br>

**Récapitulation de notre application** : 👇

</br>

:information_source: Une application Web dans le thème de Minecraft, dans lequel les utilisateurs pourront répertorier leur item, crafter, acheter ...

# Répartition du Gitlab

La racine de notre gitlab est composée de deux dossiers essentiels au projet:

[**src**](src) : **Toute la partie codage de l'application web**

[**doc**](doc) : **Documentation de l'application**

👉 [**Solution de l'application**](src/CraftSharp/CraftSharp.sln)

# Fonctionnement

- ### Comment lancer le projet ? 

Tout d'abord si ce n'est pas fait cloner le dépôt de la branche **master/main**, pour cela copier le lien URL du dépôt git :

<div align = center>

![Comment cloner](doc/Images/HowToClone.png)

</div>

Puis aller sur Visual Studio et cloner en entrant le lien :
<div align = center>

![Ou mettre sur Visual studio](doc/Images/CloneVS.png)

</div>
<br>

:information_source: *Si vous ne disposez pas de Visual Studio, allé sur le site [Microsoft Visual Studio](https://visualstudio.microsoft.com/fr/downloads/) pour pouvoir le télécharger !!!*

<br>

Une fois cela fait, cliquer sur la solution du projet **CraftSharp.sln**, il devra être normalement affiché en haut à droite de Visual studio :
<div align = center>

![Page Visual studio](doc/Images/PageVS.png)

</div>

:information_source: *Si ce n'est pas le cas aller dans l'onglet **affichage** puis cliquer sur **Explorateur de solutions**, si le problème persiste recommencer le clone ou vérifier que vous avez la bonne version de Visual studio !!!*

Maintenant il ne reste plus qu'à le lancer ! Pour cela cliquer sur la **Solution** et aller dans les propriétés :
<div align = center>

![Comment accéder aux propriétés de l'application](doc/Images/PropriétésApplication.png)

</div>

Et pour finir rajouter les modifications suivantes pour lancer les plusieurs projets au démarrage  :
<div align = center>

![Comment lancer les plusieurs projets de démarrage](doc/Images/DémarrerProjet.png)

</div>

Maintenant il ne reste plus qu'à lancer l'application :satisfied:

<div align = center>

![HowToLaunch](doc/Images/LancerApplication.png)

</div>

- ### Comment changer la langue ? 

Notre application possède plusieurs langue tel que :

- L'anglais 
- Le français
- Le turc

Si vous êtes plus habilités avec une plus que les autres, vous pouvez la changer dans la page **Connexion** et **Inscription** en cliquant juste en haut à gauche de la page : 
<div align = center>

![HowToChange](doc/Images/ChangerLangue1.png)

</div>

Pour les autres, il se trouvera tout en bas à gauche de la page :
<div align = center>

![HowToChange](doc/Images/ChangerLangue2.png)

</div>

- ### Comment fonctionne l'application ? 

Pas très compliqué! Tout d'abord il est à savoir qu'il existe deux utilisateurs différents avec des droits qui sont aussi différents (Même si ce n'est pas tant que sa): 

- L'utilisateur simple qui s'est inscrit sur l'application via le formulaire d'inscription.
- L'admin enregistrer directement dans l'application (Il n'y a pas de formulaire d'inscription pour être admin), qui lui à en plus la possibilité d'accéder directement avec l'API.

Vous voulez être Admin et profiter pleinement des fonctionnalités de l'Application, voici un compte avec lequel vous pourrez vous connecter:

-**pseudonyme** : Admin

-**Mot de passe** : 123456

En effet on retrouve deux menus différents pour les deux utilisateurs:
- Pour l'utilisateur simple:
<div align = center>

![utilisateurMenu](doc/Images/VueUtilisateur.png)

</div>

- Pour l'admin:
<div align = center>

![adminMenu](doc/Images/VueAdmin.png)

</div>

La page **Admin** (qu'y est comme son nom l'indique que pour l'admin) permet de voir tous les items de l'API (et leur spécificités), mais pas seulement il peut si il le souhaite ajouter un nouveau, en supprime un qui ne lui pas plaît modifier, tout cela en navigant simplement et efficacement grâce à une pagination :

<div align = center>

![Liste Page](doc/Images/ListePage.png)

</div>

Tandis que pour les autres pages, ils sont les mêmes que celui d'un utilisateur simple !

On retrouve tout d'abord la page **Boutique/Magasin**, un utilisateur lors de son inscription possède déjà *250 Émeraude*, qui sont l'argent nécessaire pour acheter des clés, il peut en acheter soit acheter par 5, par 20 ou bien par 50 :

<div align = center>

![Vue de la boutique](doc/Images/PageBoutique.png)

</div>

Puis grâce à ces clés qu'il accumule, il peut ouvrir des coffres pour avoir des items (fantastique non?) dans la page **Ouverture** qui se trouve dans le menu :

<div align = center>

![Vue du coffre](doc/Images/PageCoffre.png)

</div>

Lorsqu'on clique sur *Ouvrir* (il faut aussi prendre en compte qu'on perd une clé à chaque fois que l'on ouvre un coffre) :

<div align = center>

![Vue du coffre ouvert](doc/Images/PageCoffreOuverture.png)

</div>

Une fois après avoir eu plein d'items, il peut aller dans la page **Inventaire** situé dans le menu, pour retrouver son inventaire avec tous les items qu'il à accumuler et crafter ce que bon lui semble (Il existe des milliers de combinaisons possible! pour les connaîtres voici un [site](https://fr-minecraft.net/5-aide-crafting-sur-minecraft.php) qui les regroupes tous), il a aussi la possibilité de supprimer un item de son inventaire en glissant l'objet dans la *corbeille*:

<div align = center>

![Vue du coffre ouvert](doc/Images/PageCraft.png)

</div>

Ai-je vraiment besoin d'expliquer le bouton **Déconnexion** ?!

- ### Gestion des erreurs

Maintenant passons à la gestion des erreurs sur notre application !
<br>
Commençons par la page **Connexion** et **Inscription**, comme toute bonne application, nous veillons à faire attention :

-A si le pseudonyme qu'on choisit lors de l'inscription n'existe pas :
<div align = center>

![Erreur pseudonyme déjà utiliser](doc/Images/GestionErreur1.png)

</div>
-A vérifier la connexion (En cas de pseudonyme ou mot de passe incorrect) :
<div align = center>

![Erreur pseudonyme ou mot de passe](doc/Images/GestionErreur2.png)

</div>
-Mais aussi la taille des éléments qu'on rentre lors de l'inscription et la confirmation du mot de passe :
<div align = center>

![Erreur Taille Inscription](doc/Images/GestionErreur3.png)

</div>
-Une erreur un peu plus spécifique qui a était gérer, est dans le cas où un utilisateur souhaite accéder à une page qui n'existe pas:
<div align = center>

![Erreur Url inexistant](doc/Images/GestionErreurUrl.png)

</div>
:information_source: Va être alors redirigé sur une page d'erreur qui au bout de 5secondes le ramènera à la page d'accueil.

- ### Comment ça marche au niveau du code ? 

<div align = center>

![Erreur Url inexistant](doc/Images/CodeApplication.png)

</div>

Nous avons tout d'abord, dans la solution deux grands projets, un qui est l'api qui va contenir tous les objets(**Minecraft.Crafting.Api**) et l'autre qui regroupe tout le code de notre application qui va utiliser l'API (**CraftSharp**) !

Notre application est composée de plusieurs dossiers et fichier importants :

- **Program.cs** :  Il contient le code qui est exécuté lorsque l'application est lancée et qui configure les différents composants de l'application, tels que les services et les middlewares.

- **_Imports.razor** : Il contient des directives de compilation Razor qui indiquent à Blazor les assemblys et les espaces de noms à inclure dans le projet.

- **App.razor** :  Il définit la structure de base de l'application et inclut des composants tels que le menu de navigation, la barre latérale, le contenu principal de l'application et la sélection des langues.

- **Componants** : Dossier qui contient tous les composants, qui sont des unités de code réutilisables dans notre application Blazor qui permettent de définir une interface utilisateur et un comportement spécifiques. Tel que le componant **CraftingItem** qui permet de contenir un item et qui va être utilisé  plusieurs fois...

- **wwwroot** :  Dossier de l'application qui contient les fichiers statiques qui sont accessibles par les utilisateurs, tels que les fichiers HTML, CSS, JavaScript, les images et les audios. Ces fichiers sont généralement servis directement par le serveur web sans passer par le code de l'application.

- **Ressources** : Dossier qui va stocker des fichiers de ressources, tels que des fichiers de traduction.

- **Shared** : Dossier de l'application qui contient des composants et des pages qui sont partagés par plusieurs pages et composants de l'application.

- **Pages** : Contient toutes les pages (HTML et CS).

- **Services** : Dossier qui contient des classes de service qui sont utilisées pour fournir des fonctionnalités spécifiques à l'application. Telles que l'accès aux données, la gestion des utilisateurs ou la communication avec des API externes.

- **Models** : Dossier qui va stocker les classes de modèle qui sont utilisées pour représenter les données de l'application et qui peuvent être utilisées par différents composants et pages de l'application. Pour permettre de structurer les données de l'application de manière cohérente et faciliter leur utilisation dans le code de l'application.

- **Modals** : Dossier qui contient des classes de modèle qui représentent les données utilisées par l'application. Tel que la classe *Item* qui va contenir toutes les informations d'un item dans l'API.

- **Factories** : Dossier qui contient toutes les classes de factory qui sont utilisées pour créer des objets de données ou des services.

Globalement Blazor est un framework MVVM, un patron de conception qui peut être utilisé pour structurer une application Blazor en séparant la logique de présentation de l'interface utilisateur de la logique de données et de traitement. Selon ce patron de conception, l'interface utilisateur de l'application est représentée par une vue (View), qui est généralement définie en utilisant du code HTML et des composants Blazor. La logique de données et de traitement de l'application est représentée par un modèle (Model), qui peut être défini en utilisant des classes de modèle C#.

Le troisième élément du patron MVVM est le ViewModel, qui est une classe C# qui joue le rôle d'intermédiaire entre la vue et le modèle. Le ViewModel expose les données et les commandes de l'application de manière adaptée à la vue, en utilisant des propriétés et des méthodes qui sont accessibles depuis la vue. Il peut également être utilisé pour effectuer des opérations de traitement de données avant de les envoyer au modèle ou pour mettre à jour le modèle en fonction des actions de l'utilisateur.


# Environnement de Travail

Notre environnement de travail se base sur plusieurs outils :👇

<div align = center>

---

&nbsp; ![HTML](https://img.shields.io/badge/HTML-000?style=for-the-badge&logo=html5&logoColor=white&color=orange)
&nbsp; ![CSS](https://img.shields.io/badge/CSS-000?style=for-the-badge&logo=css3&logoColor=white&color=darkblue)
&nbsp; ![Blazor](https://img.shields.io/badge/Blazor-000?style=for-the-badge&logo=blazor&logoColor=white&color=purple)
&nbsp; ![C#](https://img.shields.io/badge/Csharp-000?style=for-the-badge&logo=csharp&logoColor=white&color=blue)

---

</div>

# Technicien en charge de l'application

La composition pour le projet se voit réaliser par trois élèves de l'IUT d'Aubière:
<br>
⚙️ Emre KARTAL
<br>
⚙️ Rayhan HASSOU 
<br>
⚙️ Arthur VALIN 

<div align = center>
© Groupe 4
</div>