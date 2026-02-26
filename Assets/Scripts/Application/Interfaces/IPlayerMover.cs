using UnityEngine;

namespace Game.Application.Interfaces
{
    public interface IPlayerMover
    {
        void Move(Vector2 direction, float speed, float deltaTime);
    }
}
