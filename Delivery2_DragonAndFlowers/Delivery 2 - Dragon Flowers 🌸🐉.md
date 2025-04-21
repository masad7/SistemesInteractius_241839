# Delivery 2 - Dragon Flowers
 241839  
This is the second delivery for the course. 

## Concept

The player controls a flying dragon from a top-down perspective.  
The goal is to explore an open area where flowers randomly appear every 10 seconds.  
The project is interactive, visual and uses code-driven animation, sound and asset integration.

---



### 1. Resources and environments
- The environment was imported from the [Low Poly Simple Nature Pack](https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153) on Unity Asset Store.
- The dragon model was imported from [Free3D.com](https://free3d.com/3d-model/black-dragon-rigged-and-game-ready-92023.html).

### 2.How to import assets in Unity
- Models were imported in .fbx format.
- Assets were organized into folders (Models, Prefabs, Audio, etc.)
- Flowers were converted into prefabs and used in the spawner system.

### 3. How to import Audio assets & spatialization
- A dragon voice sound effect was added using an Audio Source component.
- Audio plays in 3D space (spatial blend activated) and/or music plays in background.

### 4. Basic animation (Scripting)
- A scripted animation was created using Mathf.Sin() to make the flower objects float and rotate, simulating idle animation.
- This was implemented via a custom script attached to the prefab.

---

##  Controls

| Key         | Action                  |
|-------------|--------------------------|
| W / S     | Move forward/backward     |
| A / D     | Turn left/right           |
| Space     | Fly upward                |
| Ctrl      | Fly downward              |

---
