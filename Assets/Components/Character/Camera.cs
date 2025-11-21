using UnityEngine;
using Mirror;

namespace Character
{
    public class Camera : NetworkBehaviour
    {
        public float sensitivity = 2.0f;
        public float maxYAngle = 80f;

        private float rotationX;

        [SerializeField] GameObject _character;

        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            this.gameObject.SetActive(isLocalPlayer);
        }

        private void Update()
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            _character.transform.Rotate(Vector3.up * mouseX * sensitivity);

            rotationX -= mouseY * sensitivity;
            rotationX = Mathf.Clamp(rotationX, -maxYAngle, maxYAngle);

            transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);

        }
    }
}

