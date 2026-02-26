using Game.Application.Interfaces;
using UnityEngine;

namespace Game.Infrastructure.UnityAdapters
{
    public class UnityInputService : IInputService
    {
        public Vector2 GetMoveInput()
        {
            var x = Input.GetAxisRaw("Horizontal");
            var y = Input.GetAxisRaw("Vertical");
            return new Vector2(x, y).normalized;
        }

        public bool PausePressed()
        {
            return Input.GetKeyDown(KeyCode.Escape);
        }
    }
}
