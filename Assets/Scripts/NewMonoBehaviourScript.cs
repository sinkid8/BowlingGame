using UnityEngine;
using Unity.Cinemachine;

public class LaunchIndicator : MonoBehaviour
{
    [SerializeField] private CinemachineCamera freeLookCamera;

    void Update()
    {
        if (freeLookCamera != null)
        {
            // Align with the camera's forward direction but only rotate around Y-axis
            transform.forward = freeLookCamera.transform.forward;
            transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
        }
    }
}
