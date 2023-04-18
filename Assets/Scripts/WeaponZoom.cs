using Cinemachine;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera playerFollowCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    bool zoomedInToggle = false;

    void OnDisable()
    {
        ZoomOut();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    void ZoomOut()
    {
        zoomedInToggle = false;
        playerFollowCamera.m_Lens.FieldOfView = zoomedOutFOV;
    }

    void ZoomIn()
    {
        zoomedInToggle = true;
        playerFollowCamera.m_Lens.FieldOfView = zoomedInFOV;
    }
}
