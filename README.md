🏃 ESCAPE 🏃
🚀 Escape: Survival 2D Bienvenue sur le jeu Escape, un jeu d'arcade nerveux développé sous Unity 6. Esquivez les bombes, gérez vos points de vie et survivez à la pluie d'objets !

🎮 Le Concept Vous contrôlez un joueur en bas de l'écran. Votre mission : Survivre. Des objets tombent du ciel à une fréquence aléatoire. Chaque collision a un impact direct sur votre santé ou vos capacités.

Déplacement : Flèches Gauche / Droite (ou Q / D).

Objectif : Garder vos HP au-dessus de 0 le plus longtemps possible.

🛠️ Coulisses Techniques Ce projet met en œuvre des concepts clés du développement de jeux vidéo :

Système de Santé (PlayerHealth.cs) : Gestion des points de vie et détection de collisions intelligentes via le nom des objets.

Spawning Aléatoire (SpawnerScript.cs) : Utilisation de InvokeRepeating pour créer une difficulté progressive avec différents types de prefabs.

Coroutines : Gestion des effets temporaires (comme le boost de vitesse) sans bloquer le reste du jeu.

UI Dynamique : Affichage en temps réel des HP et écran de "Game Over" automatique.

📦 Les Objets du Jeu Voici les différents éléments qui tomberont du ciel durant votre partie. Apprenez à les reconnaître pour survivre !

🔴 La Bombe (ItemBomb)

Effet : Inflige -2 HP au joueur.

Fréquence : Apparaît toutes les 1 seconde.

Conseil : C'est l'obstacle de base, facile à esquiver mais mortel en groupe.

⚫ La Grosse Bombe (ItemBigBomb)

Effet : Inflige -7 HP. C'est un danger critique !

Fréquence : Apparaît toutes les 5 secondes.

Conseil : Priorité absolue à l'esquive, elle peut terminer votre partie instantanément.

🟢 Le Soin (ItemHeal)

Effet : Redonne +4 HP (dans la limite de 10 HP max).

Fréquence : Apparaît toutes les 15 secondes.

Conseil : Ne le ratez pas, les opportunités de se soigner sont rares.

🟡 Le Boost de Vitesse (ItemSpeed)

Effet : Multiplie votre vitesse par 2 pendant 5 secondes.

Fréquence : Apparaît toutes les 20 secondes.

Conseil : Utilisez ce surplus d'agilité pour naviguer entre les grosses vagues de bombes.

🚀 Comment jouer ? (Installation)
Pour tester le jeu suivez ces étapes :

Cliquez sur le lien OneDrive fourni : 

Téléchargez le dossier nommé unity.zip.

Dézippez (extrayez) le dossier sur votre ordinateur.

Ouvrez le dossier extrait et lancez le fichier myproject.exe.

Le jeu se lancera instantanément. Bonne chance !
