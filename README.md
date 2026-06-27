# 🏫 Création du Département BTS Interactif en 3D

> Projet de Fin d'Études (PFE) — Brevet de Technicien Supérieur (BTS), Filière Systèmes et Réseaux Informatiques
> Lycée Technique Al Idrissi, Agadir — Année académique 2021/2022

## 📖 Description

Ce projet consiste à modéliser et rendre interactif, en 3D, le département BTS d'un lycée technique, afin de permettre une visualisation immersive avant toute construction réelle. L'objectif est de démontrer comment des outils de modélisation 3D et un moteur de jeu peuvent être combinés pour créer un environnement virtuel explorable et interactif (ouverture de portes, gestion de la lumière, déplacement du personnage, etc.).

Le projet se décompose en trois grandes étapes :
1. **Modélisation 3D** de l'environnement (bâtiment du département) avec SketchUp
2. **Importation** des modèles 3D dans Unity
3. **Programmation de scripts interactifs** en C# (déplacement, portes, lumières, interactions avec les objets)

## 🎥 Démonstration vidéo

Une vidéo de démonstration du résultat final est disponible ici : **[Lien à ajouter]**

## ▶️ Exécutable de test

L'exécutable pour tester le projet est disponible sur itch.io :
**https://oussamaremli03.itch.io/bts-al-idrissi-interactif-en-3d**

## 🛠️ Technologies utilisées

| Outil | Rôle |
|---|---|
| **SketchUp** | Modélisation 3D du bâtiment (murs, toiture, structure du département) |
| **Unity** (2021.2.1f1) | Moteur de jeu / intégration de l'environnement 3D, gestion caméra, lumières, interactions |
| **C#** | Scripts de gameplay et d'interaction |

### Pourquoi ces outils plutôt que Blender ?
SketchUp a été préféré pour sa simplicité et sa prise en main rapide (vs Blender, plus complexe mais plus complet). Unity + C# ont été choisis pour la gestion des interactions en temps réel (ouverture/fermeture de porte, éclairage, déplacement du personnage, prise d'objets).

## ⚙️ Fonctionnalités implémentées

- 🚶 Déplacement du personnage (clavier + souris, gestion de la gravité et du saut)
- 🚪 Ouverture / fermeture de porte interactive
- 💡 Allumage / extinction de la lumière
- 📦 Système de prise et dépôt d'objets (Pick Up / Drop)
- 🖥️ Activation/désactivation d'éléments (ex. télévision)
- 🎮 Contrôle caméra à la souris (mouselook)

## 📁 Structure du dépôt

```
.
├── Assets/              # Tous les assets Unity (modèles, scripts, scènes, animations...)
├── Packages/            # Dépendances du projet Unity
├── ProjectSettings/     # Paramètres du projet Unity
├── sketchup-data/       # Fichiers sources SketchUp (.skp) du bâtiment
├── docs/
│   └── PFE_Rapport.pdf  # Rapport complet du PFE
├── .gitignore
├── .gitattributes       # Configuration Git LFS (fichiers volumineux)
└── README.md
```

> ⚠️ Les dossiers `Library/`, `Temp/`, `Logs/` et `UserSettings/` ne sont **pas** versionnés : ils sont régénérés automatiquement par Unity à l'ouverture du projet.

## 🚀 Comment ouvrir le projet

1. Cloner le dépôt :
   ```bash
   git clone https://github.com/<ton-pseudo>/<nom-du-repo>.git
   ```
2. Installer [Git LFS](https://git-lfs.com/) si ce n'est pas déjà fait, puis :
   ```bash
   git lfs pull
   ```
3. Ouvrir le dossier du projet avec **Unity Hub**, en utilisant la version **2021.2.1f1** (ou une version compatible plus récente).
4. Laisser Unity réimporter les assets (peut prendre quelques minutes au premier lancement).


## 📄 Rapport complet

Le rapport PFE détaillé (présentation du projet, étude comparative des outils, méthodologie, scripts commentés) est disponible dans [`docs/PFE_Rapport.pdf`](./docs/PFE_Rapport.pdf).

## 📜 Licence

Ce projet est distribué sous la **Apache License 2.0**. Voir le fichier [LICENSE](./LICENSE) pour plus de détails.
