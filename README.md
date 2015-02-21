# SpaceBass95
A rhythm-based shmup in Unity

## Gameplay
SpaceBass95 is a 2D top-town shoot-em-up with a rhythmic twist. The player controls a small spacecraft that flies
omnidirectionally. There are two alternating modes of play: Traversal Mode and Combat Mode.
### Traversal Mode
In Traversal Mode, the player can move freely but cannot shoot. Enemy ships are dispersed throughout the playing field,
moving along various paths in time to the background music. When the player is close to an enemy ship, the game enters
Combat Mode. Additoinally, upon encountering an enemy, the following outcomes are possible:
   1. If the enemy is moving and the player is at rest, the tempo of the BGM increases.
   2. If both the player and the enemy are moving, the tempo of the BGM does not change.
   3. If the player is moving and enemy is at rest, the tempo of the BGM decreases.

### Combat Mode
In Combat Mode, the player controls a cursor that moves in a fixed circle (henceforth referred to as the Beat Ring). This
Beat Ring represents one measure of rhythm. Along the perimeter of the Beat Ring are notes that the player must hit as
the cursor passes over them. The speed of the cursor is based on the tempo of the BGM. If the player hits a certain
number of notes, the enemy is destroyed and the game returns to Traversal Mode. However, if the player takes damage upon
missing a note. Once the player misses enough notes, it's game over.

## Controls
   WASD or Left Analog - Move (Traversal Mode only)
   J/K or RB/LB - Shoot (Combat Mode only)

   
