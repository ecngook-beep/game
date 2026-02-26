# Unity Import & Scene Setup Guide

## 1) Import into Unity

1. Open **Unity Hub**.
2. Click **Add project from disk**.
3. Select the repository root (`/workspace/game`).
4. Use a recent LTS editor version (2022.3+ recommended).
5. Open the project and let scripts compile.
6. Install TextMeshPro essentials if prompted.

## 2) Required Packages

- TextMeshPro (usually preinstalled with Unity UI)
- CharacterController component (built-in)

## 3) Required GameObject Hierarchy

Create a scene with this hierarchy:

```text
Scene
├── Systems
│   ├── GameInstaller (GameInstaller.cs)
│   └── GameBootstrapper (GameBootstrapper.cs)
├── Player
│   ├── CharacterControllerMover (CharacterControllerMover.cs)
│   └── Model (optional mesh child)
├── Main Camera
│   └── FollowCamera (FollowCamera.cs)
└── Canvas
    └── HUD
        └── HudView (HudView.cs)
```

## 4) Inspector Setup Values

### Systems/GameInstaller
- **Player Mover**: drag `Player` object with `CharacterControllerMover`
- **Hud View**: drag `Canvas/HUD` object with `HudView`
- **Config**: create and assign `GameConfig` asset (Create -> Game -> Config)

### Systems/GameBootstrapper
- **Installer**: drag `Systems/GameInstaller`

### Player
- Add `CharacterController`
  - Height: `2`
  - Radius: `0.4`
  - Center: `(0,1,0)`
- Add `CharacterControllerMover`
  - **Orientation**: leave empty for world-axis movement OR assign camera pivot for camera-relative movement

### Main Camera
- Add `FollowCamera`
  - **Target**: `Player`
  - **Offset**: `(0,8,-6)`
  - **Smooth Time**: `0.2`

### Canvas/HUD
- Add `HudView`
  - **Health Value**: TextMeshProUGUI for health label
  - **Currency Value**: TextMeshProUGUI for gold label

### GameConfig asset defaults
- **Default Max Health**: `100`
- **Default Move Speed**: `6`
- **Startup Currency Reward**: `25`

## 5) Suggested Asset Store Replacements

Use these categories to swap placeholder visuals quickly:

- **Character**: any stylized/realistic controller-ready player pack
- **Environment**: low-poly environment packs (modular terrains/buildings)
- **UI**: RPG/HUD icon packs for currency and health frames
- **VFX**: hit effects and coin pickup particles
- **Audio**: free SFX bundles for footsteps/UI clicks/pickups

Recommended search terms:
- `low poly character controller`
- `modular dungeon pack`
- `RPG UI pack TextMeshPro`
- `stylized VFX particles`
- `casual game audio bundle`

## 6) Extending the Architecture

- Add new gameplay rules in `Domain`.
- Add orchestrating use-cases in `Application/UseCases`.
- Add new adapters (analytics, addressables, cloud save) in `Infrastructure`.
- Keep MonoBehaviour view logic in `Presentation` only.
