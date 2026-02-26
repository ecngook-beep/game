using Game.Application.Interfaces;
using UnityEngine;

namespace Game.Infrastructure.UnityAdapters
{
    [RequireComponent(typeof(CharacterController))]
    public class CharacterControllerMover : MonoBehaviour, IPlayerMover
    {
        [SerializeField] private Transform orientation;

        private CharacterController _characterController;

        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }

        public void Move(Vector2 direction, float speed, float deltaTime)
        {
            var worldDirection = new Vector3(direction.x, 0f, direction.y);

            if (orientation != null)
            {
                worldDirection = orientation.TransformDirection(worldDirection);
                worldDirection.y = 0f;
            }

            _characterController.Move(worldDirection * (speed * deltaTime));
        }
    }
}
