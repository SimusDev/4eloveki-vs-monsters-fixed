using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.TextCore.Text;

namespace Character
{
    public class Physics : MonoBehaviour
    {
        [SerializeField] private CharacterController _character;
        [SerializeField] float gravity = 9.8f;

        public Vector3 velocity = Vector3.zero;

        private void Update()
        {
            
        }

        void FixedUpdate()
        {

            if (!_character.isGrounded)
            {
                velocity.y -= gravity * Time.fixedDeltaTime;
            }
            else if (velocity.y < 0)
            {
                velocity.y = -1f;
            }

            _character.Move(velocity * Time.fixedDeltaTime);
        }

        void ApplyImpulse(Vector3 impulse)
        {
            velocity += impulse;
        }   
    }
    
}
