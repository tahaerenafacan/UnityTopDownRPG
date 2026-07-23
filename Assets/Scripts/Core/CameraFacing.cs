using UnityEngine;

namespace RPG.Core
{
    public class CameraFacing : MonoBehaviour
    {
        private Camera cam;

        private void Start()
        {
            cam = Camera.main;
        }

        void LateUpdate()
        {
            transform.forward = cam.transform.forward;
        }
    }
}