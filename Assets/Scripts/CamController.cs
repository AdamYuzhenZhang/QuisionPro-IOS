using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    [SerializeField] private Camera m_ViewerCam;
    [SerializeField] private Camera m_ARCam;

    public void SwitchToViewerCam()
    {
        m_ARCam.enabled = false;
        m_ViewerCam.enabled = true;
    }
    public void SwitchToARCam()
    {
        m_ViewerCam.enabled = false;
        m_ARCam.enabled = true;
    }
}
