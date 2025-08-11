## Combat et Système de Jeu
- [ ] Implémenter la gestion des tours entre joueurs et ennemis
- [ ] Créer un système de combat avec attaques et capacités dynamique
- [ ] Ajouter des animations d'attaque et de dégâts

## Système de Sélection
- [ ] Ajouter des effets visuels pour la sélection (ex: surbrillance)

## Interface Utilisateur
- [ ] Développer le contenu de [`AbilitiesPanel`](Scripts/Vue/Selector/Components/AbilitiesPanel.cs) avec des boutons d'actions
- [ ] Ajouter des icônes et descriptions pour les capacités
- [ ] Créer un système de feedback visuel pour les actions (cooldowns, coûts)
- [ ] Améliorer l'affichage des barres de vie dans [`Status`](Scripts/Vue/Status/Status.cs)

## Système de Personnages
- [ ] Étendre [`BaseCharacter`](Scripts/Characters/BaseCharacter.cs) avec des stats (attaque, défense, vitesse)
- [ ] Différencier [`BaseEnemy`](Scripts/Enemies/BaseEnemy.cs) avec des comportements IA
- [ ] Ajouter un système de niveaux et d'expérience
- [ ] Implémenter différents types de personnages/classes

## Architecture et Code
- [ ] Refactoriser le code dupliqué entre BaseCharacter et BaseEnemy
- [ ] Créer un système d'événements pour les interactions de combat
- [ ] Ajouter un gestionnaire de scène pour les transitions
- [ ] Implémenter un système de sauvegarde/chargement

## Audio et Effets
- [ ] Ajouter des effets sonores pour les actions
- [ ] Créer des effets de particules pour les attaques
- [ ] Implémenter de la musique de fond

## Tests et Debug
- [ ] Retirer le debug input dans BaseCharacter._Process()
- [ ] Ajouter des tests unitaires pour les systèmes critiques
- [ ] Créer un mode debug avec informations détaillées