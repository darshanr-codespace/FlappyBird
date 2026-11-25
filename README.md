# Flappy Bird

A small 2D arcade game made with Unity. Guide the bird through the gaps between moving pipes, avoid collisions, and try to get the highest score.

## Download

[Download the Windows game](./flappybird.zip) (ZIP, about 40 MB). Extract the archive and run `flappybird/FlappyBird.exe`.

## How to Play

- Press **Space** to make the bird flap upward.
- Pass through the gaps in the pipes to earn points.
- Avoid hitting pipes or other obstacles; a collision ends the run.

## Run the Game

1. Install Unity Editor **6000.6.10f1** using Unity Hub.
2. In Unity Hub, open this project folder.
3. Open `Assets/Scenes/SampleScene.unity`.
4. Press the Play button in the Unity Editor, then press **Space** to play.

## Build

The project includes a Windows build profile. In the Unity Editor, open **File > Build Profiles**, select the Windows profile, and build the game.

## Project Contents

- `Assets/Scenes/SampleScene.unity` — the main game scene.
- `Assets/Pipe.prefab` — the pipe obstacle prefab.
- `Assets/BirdScript.cs` — bird movement and collision handling.
- `Assets/SpanerScript.cs` — pipe spawning.
- `Assets/PipeMoveScript.cs` — pipe movement.
- `Assets/MiddlePipeScript.cs` — score trigger.
- `Assets/LogicScript.cs` — score and game-over logic.
- `Packages/manifest.json` — Unity package dependencies.
# FlappyBird
