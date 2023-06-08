using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    // stores the left eye and right eye
    private GameObject m_LeftEye;
    private GameObject m_RightEye;
    public GameObject LeftEye
    {
        get => m_LeftEye;
        set => m_LeftEye = value;
    }
    public GameObject RightEye
    {
        get => m_RightEye;
        set => m_RightEye = value;
    }

    [SerializeField] private GameObject m_ViewerCamRoot;

    private void Update()
    {
        // move camera to left eye if it exists
        if (LeftEye)
        {
            Vector3 eyePos = LeftEye.transform.position;
            m_ViewerCamRoot.transform.position = new Vector3(-eyePos.x, eyePos.y, eyePos.z);
            //m_ViewerCamRoot.transform.position = LeftEye.transform.position;
            //m_ViewerCamRoot.transform.rotation = LeftEye.transform.rotation;
        }
        
        MatchSceneRotation();
    }
    
    
    // match scene rotation
    [SerializeField] private GameObject m_SceneRoot;
    [SerializeField] private GameObject m_ARCam;

    private void MatchSceneRotation()
    {
        Vector3 eulerRotation = m_ARCam.transform.rotation.eulerAngles;
        m_SceneRoot.transform.rotation = Quaternion.Euler(new Vector3(eulerRotation.x, -eulerRotation.y, -eulerRotation.z));
    }
}
