using UnityEngine;

namespace Game.Presentation.Cameras
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private Vector3 offset = new(0f, 8f, -6f);
        [SerializeField] private float smoothTime = 0.2f;

        private Vector3 _velocity;

        private void LateUpdate()
        {
            if (target == null)
            {
                return;
            }

            var targetPosition = target.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity, smoothTime);
            transform.LookAt(target);
        }
    }
}
