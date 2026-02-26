using UnityEngine;

namespace Game.Application.Interfaces
{
    public interface IInputService
    {
        Vector2 GetMoveInput();
        bool PausePressed();
    }
}
