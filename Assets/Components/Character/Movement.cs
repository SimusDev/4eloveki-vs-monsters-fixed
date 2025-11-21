using System;
using UnityEditor.Rendering;
using UnityEngine;

namespace Character
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private CharacterController _character;
        Physics _physics;
        
        public float moveSpeed = 1f;

        private void Start()
        {
            _physics = _character.GetComponent<Physics>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && _character.isGrounded)
            {
                _physics.velocity.y += 15f;
                Debug.Log("SEEEEX");
            }
            
        }

        private void FixedUpdate()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 moveDirection = (transform.forward * verticalInput) + (transform.right * horizontalInput);



            if (_physics)
            {
                _physics.velocity.x = (moveDirection * moveSpeed).x;
                _physics.velocity.z = (moveDirection * moveSpeed).z;
            }

        }

    }
}

