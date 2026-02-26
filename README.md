# Modular Unity Game Foundation (Clean Architecture)

This repository provides a complete **Unity starter architecture** with clean separation between:

- **Domain** (pure business rules)
- **Application** (use-cases and interfaces)
- **Infrastructure** (Unity and persistence adapters)
- **Presentation** (MonoBehaviours, HUD, camera, bootstrap)

## Folder Layout

```text
Assets/
  Scripts/
    Domain/
      Core/
      Gameplay/
      Player/
    Application/
      Interfaces/
      Services/
      UseCases/
    Infrastructure/
      Composition/
      Persistence/
      UnityAdapters/
    Presentation/
      Bootstrap/
      Cameras/
      UI/
Docs/
  UNITY_SETUP.md
```

## Architecture Notes

- `Domain` has no dependency on Unity scene objects.
- `Application` expresses use-cases through interfaces.
- `Infrastructure` connects interfaces to Unity APIs (`Input`, `PlayerPrefs`, `CharacterController`).
- `Presentation` handles scene references and rendering.

See setup details in `Docs/UNITY_SETUP.md`.
